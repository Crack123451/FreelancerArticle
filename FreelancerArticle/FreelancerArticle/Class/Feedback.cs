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
    }
}
