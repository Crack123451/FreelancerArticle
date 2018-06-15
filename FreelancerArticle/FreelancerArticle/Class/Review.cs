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
    class Review
    {
        public static SqlCommand RequestCommentFreelancer(string loginFreelancer)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Комментарий] FROM [Reviews] WHERE [Фрилансер]='" + loginFreelancer + "'", User.sqlConnection);
            return command;
        }
    }
}
