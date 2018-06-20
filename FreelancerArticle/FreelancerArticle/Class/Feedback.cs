using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerArticle
{
    class Feedback
    {
        public static SqlCommand RequestFreelancerByOrder(string numberOrder)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Фрилансер] FROM [Feedback] WHERE [№ Заказа] = '" + numberOrder + "'", User.sqlConnection);
            return command;
        }

        public static SqlCommand RequestAllFeedbackFreelancer(string loginFreelancer)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [№ Заказа] FROM [Feedback] WHERE [Фрилансер] = '" + loginFreelancer + "'", User.sqlConnection);
            return command;
        }

        public static SqlCommand ChechLastNumberFeedback()
        {
            SqlCommand command = new SqlCommand
                ("SELECT [№ Отклика] FROM [Feedback]", User.sqlConnection);
            return command;
        }

        public static SqlCommand AddFeedback(string numberFeedback, string loginFreelancer, string numberOrder)
        {
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Feedback]([№ Отклика],[Фрилансер],[№ Заказа]) " +
                "VALUES ('" + numberFeedback + "',N'" + loginFreelancer + "','" + numberOrder + "')", User.sqlConnection);
            return command;
        }

        public static SqlCommand DeleteFeedback(string numberOrder)
        {
            SqlCommand command = new SqlCommand
                ("DELETE FROM [Feedback] WHERE [№ Заказа]='" + numberOrder + "'", User.sqlConnection);
            return command;
        }
    }
}
