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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormRegistration();
            f.ShowDialog();
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            comboBoxWhoYou.Text = "Заказчик";
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            Form f = null;
            SqlDataReader sqlReader = null;
            string whoYou = comboBoxWhoYou.SelectedItem.ToString();
            SqlConnection sqlConnection=User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandWhoYou = User.RequestAttributes(whoYou, "[Логин],[Пароль]");
            try
            {
                sqlReader = await commandWhoYou.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    if(textBoxLogin.Text.ToString()==sqlReader["Логин"].ToString() 
                        && textBoxPassword.Text.ToString()== sqlReader["Пароль"].ToString())
                    {
                        this.Hide();
                        if (whoYou == "Заказчик")
                            f = new FormClient(sqlReader["Логин"].ToString());
                        else if (whoYou == "Фрилансер")
                            f = new FormFreelancer(sqlReader["Логин"].ToString());
                        else
                            f = new FormModerator(sqlReader["Логин"].ToString());
                        f.ShowDialog();
                        this.Close();
                    }                       
                }
                if(f==null) MessageBox.Show("Такого пользователя не существует!", "Ошибка");
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
