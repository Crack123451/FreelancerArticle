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
    public partial class FormReview : Form
    {
        string LoginFreelancer;
        int CountComment=0;
        public FormReview(string loginFreelancer)
        {
            LoginFreelancer = loginFreelancer;
            InitializeComponent();
        }

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            int count=0;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerInfo = Review.RequestCommentFreelancer(LoginFreelancer);
            try
            {
                sqlReader = await commandTextBoxCustomerInfo.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    if (count == CountComment)
                    {
                        textBoxReview.Text = sqlReader["Комментарий"].ToString();
                        CountComment++;
                        break;
                    }
                    else count++;
                }
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
