namespace FreelancerArticle
{
    partial class FormInfoAboutFreelancer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirmFreelancer = new System.Windows.Forms.Button();
            this.textBoxNameFree = new System.Windows.Forms.TextBox();
            this.textBoxLastNameFree = new System.Windows.Forms.TextBox();
            this.textBoxPatronymicFree = new System.Windows.Forms.TextBox();
            this.textBoxLoginFree = new System.Windows.Forms.TextBox();
            this.labelPatronymicFree = new System.Windows.Forms.Label();
            this.labelLastNameFree = new System.Windows.Forms.Label();
            this.labelNameFree = new System.Windows.Forms.Label();
            this.labelLoginFree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirmFreelancer
            // 
            this.buttonConfirmFreelancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmFreelancer.Location = new System.Drawing.Point(21, 185);
            this.buttonConfirmFreelancer.Name = "buttonConfirmFreelancer";
            this.buttonConfirmFreelancer.Size = new System.Drawing.Size(240, 36);
            this.buttonConfirmFreelancer.TabIndex = 22;
            this.buttonConfirmFreelancer.Text = "Подтвердить фрилансера";
            this.buttonConfirmFreelancer.UseVisualStyleBackColor = true;
            this.buttonConfirmFreelancer.Click += new System.EventHandler(this.buttonConfirmFreelancer_Click);
            // 
            // textBoxNameFree
            // 
            this.textBoxNameFree.Location = new System.Drawing.Point(103, 65);
            this.textBoxNameFree.Name = "textBoxNameFree";
            this.textBoxNameFree.ReadOnly = true;
            this.textBoxNameFree.Size = new System.Drawing.Size(158, 22);
            this.textBoxNameFree.TabIndex = 16;
            // 
            // textBoxLastNameFree
            // 
            this.textBoxLastNameFree.Location = new System.Drawing.Point(103, 98);
            this.textBoxLastNameFree.Name = "textBoxLastNameFree";
            this.textBoxLastNameFree.ReadOnly = true;
            this.textBoxLastNameFree.Size = new System.Drawing.Size(158, 22);
            this.textBoxLastNameFree.TabIndex = 19;
            // 
            // textBoxPatronymicFree
            // 
            this.textBoxPatronymicFree.Location = new System.Drawing.Point(103, 131);
            this.textBoxPatronymicFree.Name = "textBoxPatronymicFree";
            this.textBoxPatronymicFree.ReadOnly = true;
            this.textBoxPatronymicFree.Size = new System.Drawing.Size(158, 22);
            this.textBoxPatronymicFree.TabIndex = 17;
            // 
            // textBoxLoginFree
            // 
            this.textBoxLoginFree.Location = new System.Drawing.Point(103, 32);
            this.textBoxLoginFree.Name = "textBoxLoginFree";
            this.textBoxLoginFree.ReadOnly = true;
            this.textBoxLoginFree.Size = new System.Drawing.Size(158, 22);
            this.textBoxLoginFree.TabIndex = 14;
            // 
            // labelPatronymicFree
            // 
            this.labelPatronymicFree.AutoSize = true;
            this.labelPatronymicFree.Location = new System.Drawing.Point(18, 131);
            this.labelPatronymicFree.Name = "labelPatronymicFree";
            this.labelPatronymicFree.Size = new System.Drawing.Size(71, 17);
            this.labelPatronymicFree.TabIndex = 21;
            this.labelPatronymicFree.Text = "Отчество";
            // 
            // labelLastNameFree
            // 
            this.labelLastNameFree.AutoSize = true;
            this.labelLastNameFree.Location = new System.Drawing.Point(18, 98);
            this.labelLastNameFree.Name = "labelLastNameFree";
            this.labelLastNameFree.Size = new System.Drawing.Size(70, 17);
            this.labelLastNameFree.TabIndex = 20;
            this.labelLastNameFree.Text = "Фамилия";
            // 
            // labelNameFree
            // 
            this.labelNameFree.AutoSize = true;
            this.labelNameFree.Location = new System.Drawing.Point(18, 65);
            this.labelNameFree.Name = "labelNameFree";
            this.labelNameFree.Size = new System.Drawing.Size(35, 17);
            this.labelNameFree.TabIndex = 18;
            this.labelNameFree.Text = "Имя";
            // 
            // labelLoginFree
            // 
            this.labelLoginFree.AutoSize = true;
            this.labelLoginFree.Location = new System.Drawing.Point(18, 32);
            this.labelLoginFree.Name = "labelLoginFree";
            this.labelLoginFree.Size = new System.Drawing.Size(47, 17);
            this.labelLoginFree.TabIndex = 15;
            this.labelLoginFree.Text = "Логин";
            // 
            // FormInfoAboutFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 233);
            this.Controls.Add(this.buttonConfirmFreelancer);
            this.Controls.Add(this.textBoxNameFree);
            this.Controls.Add(this.textBoxLastNameFree);
            this.Controls.Add(this.textBoxPatronymicFree);
            this.Controls.Add(this.textBoxLoginFree);
            this.Controls.Add(this.labelPatronymicFree);
            this.Controls.Add(this.labelLastNameFree);
            this.Controls.Add(this.labelNameFree);
            this.Controls.Add(this.labelLoginFree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInfoAboutFreelancer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробнее о фрилансере";
            this.Load += new System.EventHandler(this.FormInfoAboutFreelancer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmFreelancer;
        private System.Windows.Forms.TextBox textBoxNameFree;
        private System.Windows.Forms.TextBox textBoxLastNameFree;
        private System.Windows.Forms.TextBox textBoxPatronymicFree;
        private System.Windows.Forms.TextBox textBoxLoginFree;
        private System.Windows.Forms.Label labelPatronymicFree;
        private System.Windows.Forms.Label labelLastNameFree;
        private System.Windows.Forms.Label labelNameFree;
        private System.Windows.Forms.Label labelLoginFree;
    }
}