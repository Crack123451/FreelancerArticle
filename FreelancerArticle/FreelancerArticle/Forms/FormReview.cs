﻿using System;
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
    public partial class FormReview : Form
    {
        string LoginFreelancer;
        public FormReview(string loginFreelancer)
        {
            LoginFreelancer = loginFreelancer;
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }
    }
}
