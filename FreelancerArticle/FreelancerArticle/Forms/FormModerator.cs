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
    public partial class FormModerator : Form
    {
        string Login;
        public FormModerator(string login)
        {
            Login = login;
            InitializeComponent();
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

        private void FormModerator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Wallets". При необходимости она может быть перемещена или удалена.
            this.walletsTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Wallets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Freelancer". При необходимости она может быть перемещена или удалена.
            this.freelancerTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Freelancer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Wallets". При необходимости она может быть перемещена или удалена.
            this.walletsTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Wallets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Freelancer". При необходимости она может быть перемещена или удалена.
            this.freelancerTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Freelancer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseGridOrderCustomer.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.freelancerArticleBaseGridOrderCustomer.Order);

        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            Form f = new FormMessageForModerator();
            f.ShowDialog();
        }
    }
}
