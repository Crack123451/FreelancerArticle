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
    public partial class FormFreelancer : Form
    {
        string Login;
        public FormFreelancer(string login)
        {
            Login=login;
            InitializeComponent();
            buttonFeedback.Enabled = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormLogin();
            f.ShowDialog();
            this.Close();
        }

        private async void FormFreelancer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseGridOrderCustomer.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.freelancerArticleBaseGridOrderCustomer.Order);
            orderBindingSource.Filter = "([Назначенный фрилансер] IS NULL) OR ([Назначенный фрилансер]='" + Login + "')";

            List<string> allFeedbackFreelancer = new List<string>();
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandTextBoxCustomerInfo = User.RequestInfoUser(Login, "Freelancer");
            SqlCommand commandTextBoxCustomerWallet = Wallet.RequestInfoWalletUser(Login, "Freelancer");
            SqlCommand commandRequestAllFeedback = Feedback.RequestAllFeedbackFreelancer(Login); 
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

                sqlReader.Close();

                sqlReader = await commandRequestAllFeedback.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    allFeedbackFreelancer.Add(sqlReader["№ Заказа"].ToString());
                }
                DataGridViewCheckBoxCell txtxCell;
                for (int i = 0; i < dataGridViewOrderFreelancer.RowCount; i++)
                    if (allFeedbackFreelancer.Contains(dataGridViewOrderFreelancer.Rows[i].Cells[0].Value.ToString()))
                    {
                        txtxCell = (DataGridViewCheckBoxCell)dataGridViewOrderFreelancer.Rows[i].Cells[7];
                        txtxCell.Value = true;
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

        private void buttonMessageModerator_Click(object sender, EventArgs e)
        {
            var f = new FormSendMessageForModerator(Login);
            f.ShowDialog();
        }

        private void buttonLearnMore_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderFreelancer.CurrentCell.RowIndex > -1)
            {
                this.Hide();
                var f = new FormOrderForFreelancer(Login, Int32.Parse(dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Cells[0].Value.ToString()), dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Cells[6].Value.ToString());
                f.ShowDialog();
                this.Close();
            }
        }

        private async void buttonFeedback_Click(object sender, EventArgs e)
        {
            string lastFeedback = "";
            int newFeedback;
            string numberOrder = dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (numberOrder == null)
                goto finish;
            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandChangeStatus = Order.ChangeStatus(numberOrder, "Есть отклик");
            SqlCommand commandChechLastNumberFeedback = Feedback.ChechLastNumberFeedback();
            try
            {
                sqlReader = await commandChechLastNumberFeedback.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    lastFeedback = sqlReader["№ Отклика"].ToString();
                }
                newFeedback = Int32.Parse(lastFeedback);
                newFeedback++;

                sqlReader.Close();

                SqlCommand commandAddFeedback = Feedback.AddFeedback(newFeedback.ToString(), Login, numberOrder);
                sqlReader = await commandAddFeedback.ExecuteReaderAsync();
                sqlReader.Close();
                sqlReader = await commandChangeStatus.ExecuteReaderAsync();
                DataGridViewTextBoxCell txtxCell = (DataGridViewTextBoxCell)dataGridViewOrderFreelancer.Rows[dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Index].Cells[6];
                txtxCell.Value = "Есть отклик";
                DataGridViewCheckBoxCell txtxCell2 = (DataGridViewCheckBoxCell)dataGridViewOrderFreelancer.Rows[dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Index].Cells[7];
                txtxCell2.Value = true;
                MessageBox.Show("Вы откликнулись");
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

        private void dataGridViewOrderFreelancer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string status = dataGridViewOrderFreelancer.SelectedCells[0].OwningRow.Cells[6].Value.ToString();
            if (status == "Нет отклика" || status == "Есть отклик")
                buttonFeedback.Enabled = true;
            else
                buttonFeedback.Enabled = false;
        }
    }
}
