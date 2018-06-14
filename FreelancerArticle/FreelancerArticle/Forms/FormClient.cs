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
    public partial class FormClient : Form
    {
        string Login;
        public FormClient(string login)
        {
            Login = login;
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormPurse(Login);
            f.ShowDialog();
            this.Close();
        }

        private void buttonReviews_Click(object sender, EventArgs e)
        {
            var f = new FormReview();
            f.Show();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormLogin();
            f.ShowDialog();
            this.Close();
        }

        private async void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseGridOrderCustomer.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.freelancerArticleBaseGridOrderCustomer.Order);
            orderBindingSource.Filter = "Заказчик='" + Login + "'";

            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerInfo=User.RequestInfoUser(Login, "Customer");
            SqlCommand commandTextBoxCustomerWallet = Wallet.RequestInfoWalletUser(Login, "Customer");
            try
            {
                sqlReader = await commandTextBoxCustomerInfo.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    textBoxLogin.Text = Login;
                    textBoxName.Text = sqlReader["Имя"].ToString();
                    textBoxLastName.Text = sqlReader["Фамилия"].ToString();
                    textBoxPatronymic.Text = sqlReader["Отчество"].ToString();
                }

                sqlReader.Close();

                sqlReader = await commandTextBoxCustomerWallet.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    textBoxWallet.Text = sqlReader["№ Кошелька"].ToString();
                    textBoxSumWallet.Text = sqlReader["Сумма"].ToString();
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
