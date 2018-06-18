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

        public static SqlCommand InsertCommentFreelancer(string numberReview, string loginFreelancer, string comment)
        {
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Reviews]([№ Отзыва],[Фрилансер],[Комментарий])" +
                "VALUES ('" + numberReview + "',N'" + loginFreelancer + "',N'" + comment + "')", User.sqlConnection);
            return command;
        }

        public static SqlCommand CheckLastNumberReview()
        {
            SqlCommand command = new SqlCommand
                ("SELECT [№ Отзыва] FROM [Reviews]", User.sqlConnection);
            return command;
        }
    }
}
