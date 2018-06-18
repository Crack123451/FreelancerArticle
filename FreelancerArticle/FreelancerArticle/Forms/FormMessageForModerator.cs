using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerArticle
{
    public partial class FormMessageForModerator : Form
    {
        public FormMessageForModerator()
        {
            InitializeComponent();
        }

        private void FormMessageForModerator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "freelancerArticleBaseDataForModerator.Messenger". При необходимости она может быть перемещена или удалена.
            this.messengerTableAdapter.Fill(this.freelancerArticleBaseDataForModerator.Messenger);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
