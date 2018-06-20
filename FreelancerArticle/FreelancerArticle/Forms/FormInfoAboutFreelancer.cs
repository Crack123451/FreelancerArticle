using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerArticle
{
    public partial class FormInfoAboutFreelancer : Form
    {
        private ServiceHost Host;

        string LoginFreelancer;
        string NumberOrder;
        string Login;
        string Status;
        public FormInfoAboutFreelancer(string login, string loginFreelancer, string numberOrder, string status)
        {
            LoginFreelancer = loginFreelancer;
            Login = login;
            NumberOrder = numberOrder;
            Status = status;
            InitializeComponent();
            if (status == "Есть отклик")
                buttonConfirmFreelancer.Enabled = true;
            else
                buttonConfirmFreelancer.Enabled = false;
        }

        private async void buttonConfirmFreelancer_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandAssignFreelancer = Order.AssignFreelancer(NumberOrder, LoginFreelancer);
            try
            {
                sqlReader = await commandAssignFreelancer.ExecuteReaderAsync();
                MessageBox.Show("Фрилансер подтвержден");
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
            var f = new FormClient(Login);
        }

        private async void FormInfoAboutFreelancer_Load(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Service));
            Host.Open();

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

        private void FormInfoAboutFreelancer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Host.Close();
        }
    }
}
