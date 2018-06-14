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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string wallet="";
            for(int i=0; i<9; i++)
            {
                wallet += rnd.Next(10);
            }
            Int32.Parse(wallet);
            textBoxWallet.Text = wallet;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            comboBoxWhoYou.Text = "Заказчик";
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCheckLogin =
                User.RequestAttributes(comboBoxWhoYou.Text.ToString(), "[Логин]");

            SqlCommand commandTextBoxInsertWallet =
                Wallet.InsertInfoWallet(textBoxWallet.Text.ToString(), "0"); 
            SqlCommand commandTextBoxRegistration = 
                User.InsertInfoToDatabase(comboBoxWhoYou.Text.ToString(), textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString(), textBoxName.Text.ToString(), textBoxLastName.Text.ToString(), textBoxPatronymic.Text.ToString(), textBoxWallet.Text.ToString());
            try
            {
                sqlReader = await commandTextBoxCheckLogin.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    if (textBoxLogin.Text.ToString() == sqlReader["Логин"].ToString())
                    {
                        MessageBox.Show("Такой пользователь уже существует");
                        goto close;
                    }
                }
                sqlReader.Close();
                sqlReader = await commandTextBoxInsertWallet.ExecuteReaderAsync();
                sqlReader.Close();
                sqlReader = await commandTextBoxRegistration.ExecuteReaderAsync();
                MessageBox.Show("Вы зарегистрированы");

                close: sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные введены некорректно. Или не все поля заполнены");
            }
        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var f = new FormLogin();
            f.ShowDialog();
            this.Close();
        }
    }
}
