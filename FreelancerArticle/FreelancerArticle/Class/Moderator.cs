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
                ("SELECT [Логин пользователя],[Сообщение] FROM [Moderator]", User.sqlConnection);
            return command;
        }

        public static SqlCommand SendMessageForModerator(string loginUser, string message)
        {
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Moderator]([Логин модератора],[Логин пользователя],[Сообщение]) " +
                "VALUES (N'Admin',N'" + loginUser + "',N'" + message + "')", User.sqlConnection);
            return command;
        }
    }
}
