using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerArticle
{
    class Moderator
    {
        public static SqlCommand RequestMessageForModerator()
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Время],[Логин пользователя],[Сообщение] FROM [Moderator]", User.sqlConnection);
            return command;
        }

        public static SqlCommand SendMessageForModerator(string loginUser, string message)
        {
            string format = "yyyy.MM.dd hh:mm";
            DateTime time = DateTime.Now;
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Messenger]([№ Мессенджера],[Время],[Логин пользователя],[Сообщение]) " +
                "VALUES ('1','" + time.ToString(format) + "','" + loginUser + "',N'" + message + "')", User.sqlConnection);
            return command;
        }
    }
}
