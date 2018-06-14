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
    public partial class FormModerator : Form
    {
        public FormModerator(string login)
        {
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
    }
}
