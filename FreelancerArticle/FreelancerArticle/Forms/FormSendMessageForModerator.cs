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
    public partial class FormSendMessageForModerator : Form
    {
        string Login;
        public FormSendMessageForModerator(string login)
        {
            Login = login;
            InitializeComponent();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerInfo = Moderator.SendMessageForModerator(Login, textBoxModerator.Text.ToString());
            try
            {
                sqlReader = await commandTextBoxCustomerInfo.ExecuteReaderAsync();
                MessageBox.Show("Сообщение отправлено");
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
