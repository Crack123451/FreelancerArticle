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
            buttonConfirmWork.Enabled = false;
            buttonGiveReview.Enabled = false;
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
            if (listBoxFeedback.SelectedIndex > -1)
            {
                var f = new FormReview(listBoxFeedback.SelectedItem.ToString());
                f.ShowDialog();
            }
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

        private async void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBoxFeedback.Items.Clear();
            var numberOrder = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            var status = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[6].Value.ToString();
            //Выставление активных и неактивных кнопок, исходя из значения поля "Состояние" таблицы "Заказ"
            switch(status)
            {
                case "Фрилансер подтвержден":
                    buttonConfirmWork.Enabled = true;
                    buttonGiveReview.Enabled = true;
                    buttonConflict.Enabled = true;
                    break;
                case "Работа выполнена":
                    buttonConfirmWork.Enabled = true;
                    buttonGiveReview.Enabled = true;
                    buttonConflict.Enabled = true;
                    break;
                case "Работа подтверждена":
                    buttonConfirmWork.Enabled = false;
                    buttonGiveReview.Enabled = true;
                    buttonConflict.Enabled = false;
                    break;
                case "Конфликт":
                    buttonConfirmWork.Enabled = false;
                    buttonGiveReview.Enabled = true;
                    buttonConflict.Enabled = false;
                    break;
                default:
                    buttonConfirmWork.Enabled = false;
                    buttonGiveReview.Enabled = false;
                    buttonConflict.Enabled = false;
                    break;
            }

            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandListBoxFreelancer = Feedback.RequestFreelancerByOrder(numberOrder);
            try
            {
                sqlReader = await commandListBoxFreelancer.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBoxFeedback.Items.Add(sqlReader["Фрилансер"].ToString());
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

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (listBoxFeedback.SelectedIndex > -1)
            {
                var f = new FormInfoAboutFreelancer(Login, listBoxFeedback.SelectedItem.ToString(), dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                f.ShowDialog();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormOrder(Login);
            f.ShowDialog();
            this.Close();
        }

        private void buttonLookAt_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.CurrentCell.RowIndex > -1)
            {
                this.Hide();
                var f = new FormOrder(Login, Int32.Parse(dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString()), dataGridViewOrder.SelectedCells[0].OwningRow.Cells[6].Value.ToString());
                f.ShowDialog();
                this.Close();
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string numberOrder = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (numberOrder == null)
                goto finish;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandDeleteOrder = Order.DeleteOrder(numberOrder);
            try
            {
                sqlReader = await commandDeleteOrder.ExecuteReaderAsync();
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
            dataGridViewOrder.Rows.RemoveAt(dataGridViewOrder.CurrentCell.RowIndex);
            dataGridViewOrder.CurrentCell = dataGridViewOrder[0, 0];
            finish:;
        }

        private void buttonGiveReview_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.CurrentCell.RowIndex > -1)
            {
                var loginAssignedFreelancer = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[5].Value.ToString();
                var f = new FormGiveReview(loginAssignedFreelancer);
                f.ShowDialog();
            }
        }

        private void buttonMessageModerator_Click(object sender, EventArgs e)
        {
            var f = new FormSendMessageForModerator(Login);
            f.ShowDialog();
        }

        private async void buttonConfirmWork_Click(object sender, EventArgs e)
        {
            string numberOrder = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (numberOrder == null)
                goto finish;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxConfirmWork = Order.ChangeStatus(numberOrder, "Работа подтверждена");
            try
            {
                sqlReader = await commandTextBoxConfirmWork.ExecuteReaderAsync();
                MessageBox.Show("Работа подтверждена");
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

        private async void buttonConflict_Click(object sender, EventArgs e)
        {
            string numberOrder = dataGridViewOrder.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (numberOrder == null)
                goto finish;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxConflict = Order.ChangeStatus(numberOrder, "Конфликт");
            try
            {
                sqlReader = await commandTextBoxConflict.ExecuteReaderAsync();
                MessageBox.Show("Объявлен конфликт. Напишите модератору свои притензии. Модератор решит вопрос в течение 3 суток.");
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
    }
}
