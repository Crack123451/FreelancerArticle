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
    public partial class FormInfoAboutFreelancer : Form
    {
        string LoginFreelancer;
        public FormInfoAboutFreelancer(string loginFreelancer)
        {
            LoginFreelancer = loginFreelancer;
            InitializeComponent();
        }

        private void buttonConfirmFreelancer_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private async void FormInfoAboutFreelancer_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerInfo = User.RequestInfoUser(LoginFreelancer, "Freelancer");
            try
            {
                sqlReader = await commandTextBoxCustomerInfo.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    textBoxLoginFree.Text = LoginFreelancer;
                    textBoxNameFree.Text = sqlReader["Имя"].ToString();
                    textBoxLastNameFree.Text = sqlReader["Фамилия"].ToString();
                    textBoxPatronymicFree.Text = sqlReader["Отчество"].ToString();
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
