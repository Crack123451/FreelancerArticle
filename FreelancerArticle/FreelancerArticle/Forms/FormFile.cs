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
    public partial class FormFile : Form
    {
        string Login;
        string TransitionForm;
        int NumberOrder;
        public FormFile(string login, int numberOrder, string transitionForm)
        {
            Login = login;
            TransitionForm = transitionForm;
            NumberOrder = numberOrder;
            InitializeComponent();
            if (TransitionForm == "FormOrder")
                textBoxFile.ReadOnly = true;
            else
                textBoxFile.ReadOnly = false;
        }

        private async void buttonOK_Click(object sender, EventArgs e)
        {
            if (TransitionForm == "FormOrder")
            {
                goto finish;
            }

            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandInfoOrder = Order.SendFile(NumberOrder.ToString(), textBoxFile.Text.ToString());
            try
            {
                sqlReader = await commandInfoOrder.ExecuteReaderAsync();
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

            finish: this.Close();
        }

        private async void FormFile_Load(object sender, EventArgs e)
        {
            if (TransitionForm == "FormOrderForFreelancer")
            {
                goto finish;
            }

            SqlDataReader sqlReader = null;
            SqlConnection sqlConnection = User.EnterToDatabase();
            await sqlConnection.OpenAsync();
            SqlCommand commandInfoOrder = Order.DownloadFile(NumberOrder.ToString());
            try
            {
                sqlReader = await commandInfoOrder.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    textBoxFile.Text = sqlReader["Файл"].ToString();
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
    }
}
