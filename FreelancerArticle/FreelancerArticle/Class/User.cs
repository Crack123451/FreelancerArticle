using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FreelancerArticle
{
    class User
    {
        public static SqlConnection sqlConnection;

        public static SqlConnection EnterToDatabase()
        {
            string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\FreelancerArticleBase.mdf;Integrated Security=True";
            return sqlConnection = new SqlConnection(stringConnection);       
        }

        public static SqlCommand RequestAttributes(string whoYou, string attributesDatabase)
        {
            if (whoYou == "Заказчик") whoYou = "Customer";
            else if (whoYou == "Фрилансер") whoYou = "Freelancer";
            else whoYou = "Moderator";
            SqlCommand command = new SqlCommand
                ("SELECT " + attributesDatabase + " FROM [" + whoYou + "]", sqlConnection);          
            return command;
        }

        public static SqlCommand InsertInfoToDatabase(string whoYou, string login, string password, string name, string lastName, string patronymic, string wallet)
        {
            if (whoYou == "Заказчик") whoYou = "Customer";
            else whoYou = "Freelancer";
            SqlCommand command = new SqlCommand
                ("INSERT INTO [" + whoYou + "]([Логин],[Пароль],[Имя],[Фамилия],[Отчество],[№ Кошелька]) VALUES ('"+login+ "','" + password + "','" + name + "','" + lastName+"','"+patronymic+"','"+wallet+"')", User.sqlConnection);
            return command;
        }

        public static SqlCommand RequestInfoUser(string login, string who)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Имя],[Фамилия],[Отчество] FROM [" + who + "] WHERE [Логин]='" + login + "'", sqlConnection);
            return command;
        }


    }
}
