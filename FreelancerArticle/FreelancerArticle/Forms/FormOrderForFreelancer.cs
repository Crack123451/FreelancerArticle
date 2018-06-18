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
    public partial class FormOrderForFreelancer : Form
    {
        string Login;
        int NumberOrder;
        public FormOrderForFreelancer(string login, int numberOrder, string status)
        {
            InitializeComponent();
            Login = login;
            NumberOrder = numberOrder;
            if (status == "Фрилансер подтвержден" || status == "Работа выполнена")
                buttonPublishWork.Enabled = true;
            else
                buttonPublishWork.Enabled = false;
        }

        private async void FormOrderForFreelancer_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandInfoOrder = Order.RequestInfoOrder(NumberOrder.ToString());
            try
            {
                sqlReader = await commandInfoOrder.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    textBoxTopic.Text = sqlReader["Тема"].ToString();
                    textBoxTitle.Text = sqlReader["Название"].ToString();
                    textBoxDescription.Text = sqlReader["Подробное описание"].ToString();
                    textBoxCountSymbol.Text = sqlReader["Количество символов"].ToString();
                    textBoxMoney.Text = sqlReader["Бюджет"].ToString();
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

        private void FormOrderForFreelancer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var f = new FormFreelancer(Login);
            f.ShowDialog();
            this.Close();
        }

        private void buttonPublishWork_Click(object sender, EventArgs e)
        {
            var f = new FormFile(Login, NumberOrder, "FormOrderForFreelancer");
            f.ShowDialog();
        }
    }
}
