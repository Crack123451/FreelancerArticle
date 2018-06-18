using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerArticle
{
    public partial class FormGiveReview : Form
    {
        string LoginAssignedFreelancer;
        public FormGiveReview(string loginAssignedFreelancer)
        {
            LoginAssignedFreelancer = loginAssignedFreelancer;
            InitializeComponent();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string lastReview = "";
            int newReview;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandCheckNumberNewReview = Review.CheckLastNumberReview();
            try
            {
                sqlReader = await commandCheckNumberNewReview.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    lastReview = sqlReader["№ Отзыва"].ToString();
                }
                newReview = Int32.Parse(lastReview);
                newReview++;

                sqlReader.Close();

                SqlCommand commandInsertComment = Review.InsertCommentFreelancer(newReview.ToString(), LoginAssignedFreelancer, textBoxReview.Text.ToString());
                sqlReader = await commandInsertComment.ExecuteReaderAsync();
                MessageBox.Show("Отзыв отправлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
