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
    public partial class FormOrder : Form
    {
        string Login;
        int NumberOrder=-1;
        public FormOrder(string login)
        {
            Login = login;
            InitializeComponent();
            buttonPublish.Enabled = true;
            buttonDownload.Enabled = false;
        }

        public FormOrder(string login, int numberOrder, string status)
        {
            NumberOrder = numberOrder;
            Login = login;
            InitializeComponent();
            buttonPublish.Enabled = false;
            if(status == "Нет отклика" || status == "Есть отклик" || status == "Фрилансер подтвержден")
                buttonDownload.Enabled = false;
            else
                buttonDownload.Enabled = true;
            textBoxTopic.ReadOnly = true;
            textBoxTitle.ReadOnly = true;
            textBoxDescription.ReadOnly = true;
            textBoxCountSymbol.ReadOnly = true;
            textBoxMoney.ReadOnly = true;
        }

        private async void buttonPublish_Click(object sender, EventArgs e)
        {
            string lastOrder="";
            int newOrder;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandCheckNewNumberOrder = Order.ChechLastNumberOrder();             
            try
            {
                sqlReader = await commandCheckNewNumberOrder.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    lastOrder = sqlReader["№ Заказа"].ToString();
                }
                newOrder = Int32.Parse(lastOrder);
                newOrder++;

                sqlReader.Close();

                SqlCommand commandTextBoxOrder =
                    Order.InsertInfoToDatabaseOrder(newOrder.ToString(), Login, textBoxTopic.Text.ToString(), textBoxTitle.Text.ToString(), textBoxDescription.Text.ToString(), textBoxCountSymbol.Text.ToString(), textBoxMoney.Text.ToString());
                sqlReader = await commandTextBoxOrder.ExecuteReaderAsync();
                MessageBox.Show("Заказ успешно опубликован!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные введены некорректно. Или не все поля заполнены");
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void FormOrder_Load(object sender, EventArgs e)
        {
            if (NumberOrder == -1)
                goto finish;

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
            finish:;
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var f = new FormClient(Login);
            f.ShowDialog();
            this.Close();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            var f = new FormFile(Login, NumberOrder, "FormOrder");
            f.ShowDialog();
        }
    }
}
