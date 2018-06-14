using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerArticle
{
    class Customer : User
    {
        /*public static SqlCommand RequestInfoCustomer(string login)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Имя],[Фамилия],[Отчество] FROM [Customer] WHERE [Логин]='" + login + "'", sqlConnection);
            return command;
        }*/
    }
}
