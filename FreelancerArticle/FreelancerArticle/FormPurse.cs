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
    public partial class FormPurse : Form
    {
        string Login;
        public FormPurse(string login)
        {
            Login = login;
            InitializeComponent();
        }

        private async void buttonTransfer_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerWallet = Wallet.UpdateMoneyToDatabase(textBoxSum.Text.ToString(), Login, "Customer");
            try
            {
                sqlReader = await commandTextBoxCustomerWallet.ExecuteReaderAsync();
                MessageBox.Show("Сумма перечислена");
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

        private void FormPurse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var f = new FormClient(Login);
            f.ShowDialog();
            this.Close();
        }
    }
}
