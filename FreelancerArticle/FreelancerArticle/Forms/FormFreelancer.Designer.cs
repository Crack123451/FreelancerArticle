namespace FreelancerArticle
{
    partial class FormFreelancer
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
            this.components = new System.ComponentModel.Container();
            this.buttonLearnMore = new System.Windows.Forms.Button();
            this.dataGridViewOrderFreelancer = new System.Windows.Forms.DataGridView();
            this.заказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСимволовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бюджетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFeedback = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancerArticleBaseGridOrderCustomer = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomer();
            this.labelYourOrder = new System.Windows.Forms.Label();
            this.buttonMessageModerator = new System.Windows.Forms.Button();
            this.groupBoxYouWallet = new System.Windows.Forms.GroupBox();
            this.textBoxSumWallet = new System.Windows.Forms.TextBox();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.labelSumWallet = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.groupBoxInfoAboutYou = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderTableAdapter = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter();
            this.buttonFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderFreelancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).BeginInit();
            this.groupBoxYouWallet.SuspendLayout();
            this.groupBoxInfoAboutYou.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLearnMore
            // 
            this.buttonLearnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLearnMore.Location = new System.Drawing.Point(772, 570);
            this.buttonLearnMore.Name = "buttonLearnMore";
            this.buttonLearnMore.Size = new System.Drawing.Size(148, 41);
            this.buttonLearnMore.TabIndex = 21;
            this.buttonLearnMore.Text = "Подробнее";
            this.buttonLearnMore.UseVisualStyleBackColor = true;
            this.buttonLearnMore.Click += new System.EventHandler(this.buttonLearnMore_Click);
            // 
            // dataGridViewOrderFreelancer
            // 
            this.dataGridViewOrderFreelancer.AllowUserToAddRows = false;
            this.dataGridViewOrderFreelancer.AllowUserToDeleteRows = false;
            this.dataGridViewOrderFreelancer.AllowUserToOrderColumns = true;
            this.dataGridViewOrderFreelancer.AutoGenerateColumns = false;
            this.dataGridViewOrderFreelancer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderFreelancer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.заказаDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоСимволовDataGridViewTextBoxColumn,
            this.бюджетDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn,
            this.ColumnFeedback});
            this.dataGridViewOrderFreelancer.DataSource = this.orderBindingSource;
            this.dataGridViewOrderFreelancer.Location = new System.Drawing.Point(23, 300);
            this.dataGridViewOrderFreelancer.Name = "dataGridViewOrderFreelancer";
            this.dataGridViewOrderFreelancer.ReadOnly = true;
            this.dataGridViewOrderFreelancer.RowTemplate.Height = 24;
            this.dataGridViewOrderFreelancer.Size = new System.Drawing.Size(913, 251);
            this.dataGridViewOrderFreelancer.TabIndex = 20;
            // 
            // заказаDataGridViewTextBoxColumn
            // 
            this.заказаDataGridViewTextBoxColumn.DataPropertyName = "№ Заказа";
            this.заказаDataGridViewTextBoxColumn.Frozen = true;
            this.заказаDataGridViewTextBoxColumn.HeaderText = "№ Заказа";
            this.заказаDataGridViewTextBoxColumn.Name = "заказаDataGridViewTextBoxColumn";
            this.заказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.заказаDataGridViewTextBoxColumn.Width = 50;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Frozen = true;
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.ReadOnly = true;
            this.заказчикDataGridViewTextBoxColumn.Width = 80;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.Frozen = true;
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.Frozen = true;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 110;
            // 
            // количествоСимволовDataGridViewTextBoxColumn
            // 
            this.количествоСимволовDataGridViewTextBoxColumn.DataPropertyName = "Количество символов";
            this.количествоСимволовDataGridViewTextBoxColumn.Frozen = true;
            this.количествоСимволовDataGridViewTextBoxColumn.HeaderText = "Количество символов";
            this.количествоСимволовDataGridViewTextBoxColumn.Name = "количествоСимволовDataGridViewTextBoxColumn";
            this.количествоСимволовDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоСимволовDataGridViewTextBoxColumn.Width = 60;
            // 
            // бюджетDataGridViewTextBoxColumn
            // 
            this.бюджетDataGridViewTextBoxColumn.DataPropertyName = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.Frozen = true;
            this.бюджетDataGridViewTextBoxColumn.HeaderText = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.Name = "бюджетDataGridViewTextBoxColumn";
            this.бюджетDataGridViewTextBoxColumn.ReadOnly = true;
            this.бюджетDataGridViewTextBoxColumn.Width = 50;
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Frozen = true;
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            this.состояниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.состояниеDataGridViewTextBoxColumn.Width = 140;
            // 
            // ColumnFeedback
            // 
            this.ColumnFeedback.Frozen = true;
            this.ColumnFeedback.HeaderText = "Ваш отклик";
            this.ColumnFeedback.Name = "ColumnFeedback";
            this.ColumnFeedback.ReadOnly = true;
            this.ColumnFeedback.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnFeedback.Width = 50;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.freelancerArticleBaseGridOrderCustomer;
            // 
            // freelancerArticleBaseGridOrderCustomer
            // 
            this.freelancerArticleBaseGridOrderCustomer.DataSetName = "FreelancerArticleBaseGridOrderCustomer";
            this.freelancerArticleBaseGridOrderCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelYourOrder
            // 
            this.labelYourOrder.AutoSize = true;
            this.labelYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourOrder.Location = new System.Drawing.Point(17, 261);
            this.labelYourOrder.Name = "labelYourOrder";
            this.labelYourOrder.Size = new System.Drawing.Size(113, 32);
            this.labelYourOrder.TabIndex = 19;
            this.labelYourOrder.Text = "Заказы";
            // 
            // buttonMessageModerator
            // 
            this.buttonMessageModerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessageModerator.Location = new System.Drawing.Point(681, 246);
            this.buttonMessageModerator.Name = "buttonMessageModerator";
            this.buttonMessageModerator.Size = new System.Drawing.Size(255, 41);
            this.buttonMessageModerator.TabIndex = 18;
            this.buttonMessageModerator.Text = "Написать модератору";
            this.buttonMessageModerator.UseVisualStyleBackColor = true;
            this.buttonMessageModerator.Click += new System.EventHandler(this.buttonMessageModerator_Click);
            // 
            // groupBoxYouWallet
            // 
            this.groupBoxYouWallet.Controls.Add(this.textBoxSumWallet);
            this.groupBoxYouWallet.Controls.Add(this.textBoxWallet);
            this.groupBoxYouWallet.Controls.Add(this.labelSumWallet);
            this.groupBoxYouWallet.Controls.Add(this.labelWallet);
            this.groupBoxYouWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxYouWallet.Location = new System.Drawing.Point(681, 42);
            this.groupBoxYouWallet.Name = "groupBoxYouWallet";
            this.groupBoxYouWallet.Size = new System.Drawing.Size(255, 115);
            this.groupBoxYouWallet.TabIndex = 17;
            this.groupBoxYouWallet.TabStop = false;
            this.groupBoxYouWallet.Text = "Ваш кошелек";
            // 
            // textBoxSumWallet
            // 
            this.textBoxSumWallet.Location = new System.Drawing.Point(91, 64);
            this.textBoxSumWallet.Name = "textBoxSumWallet";
            this.textBoxSumWallet.ReadOnly = true;
            this.textBoxSumWallet.Size = new System.Drawing.Size(158, 24);
            this.textBoxSumWallet.TabIndex = 2;
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Location = new System.Drawing.Point(91, 31);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.ReadOnly = true;
            this.textBoxWallet.Size = new System.Drawing.Size(158, 24);
            this.textBoxWallet.TabIndex = 1;
            // 
            // labelSumWallet
            // 
            this.labelSumWallet.AutoSize = true;
            this.labelSumWallet.Location = new System.Drawing.Point(6, 64);
            this.labelSumWallet.Name = "labelSumWallet";
            this.labelSumWallet.Size = new System.Drawing.Size(56, 18);
            this.labelSumWallet.TabIndex = 2;
            this.labelSumWallet.Text = "Сумма";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Location = new System.Drawing.Point(6, 31);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(55, 18);
            this.labelWallet.TabIndex = 1;
            this.labelWallet.Text = "Номер";
            // 
            // groupBoxInfoAboutYou
            // 
            this.groupBoxInfoAboutYou.Controls.Add(this.textBoxName);
            this.groupBoxInfoAboutYou.Controls.Add(this.textBoxLastName);
            this.groupBoxInfoAboutYou.Controls.Add(this.textBoxPatronymic);
            this.groupBoxInfoAboutYou.Controls.Add(this.textBoxLogin);
            this.groupBoxInfoAboutYou.Controls.Add(this.labelPatronymic);
            this.groupBoxInfoAboutYou.Controls.Add(this.labelLastName);
            this.groupBoxInfoAboutYou.Controls.Add(this.labelName);
            this.groupBoxInfoAboutYou.Controls.Add(this.labelLogin);
            this.groupBoxInfoAboutYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfoAboutYou.Location = new System.Drawing.Point(23, 42);
            this.groupBoxInfoAboutYou.Name = "groupBoxInfoAboutYou";
            this.groupBoxInfoAboutYou.Size = new System.Drawing.Size(255, 170);
            this.groupBoxInfoAboutYou.TabIndex = 15;
            this.groupBoxInfoAboutYou.TabStop = false;
            this.groupBoxInfoAboutYou.Text = "Информация о вас";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(158, 24);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(91, 97);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(158, 24);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(91, 130);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(158, 24);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(91, 31);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(158, 24);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(6, 130);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(75, 18);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 97);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 18);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 18);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 31);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 18);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFeedback
            // 
            this.buttonFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFeedback.Location = new System.Drawing.Point(579, 570);
            this.buttonFeedback.Name = "buttonFeedback";
            this.buttonFeedback.Size = new System.Drawing.Size(167, 41);
            this.buttonFeedback.TabIndex = 23;
            this.buttonFeedback.Text = "Откликнуться";
            this.buttonFeedback.UseVisualStyleBackColor = true;
            // 
            // FormFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.buttonFeedback);
            this.Controls.Add(this.buttonLearnMore);
            this.Controls.Add(this.dataGridViewOrderFreelancer);
            this.Controls.Add(this.labelYourOrder);
            this.Controls.Add(this.buttonMessageModerator);
            this.Controls.Add(this.groupBoxYouWallet);
            this.Controls.Add(this.groupBoxInfoAboutYou);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFreelancer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFreelancer";
            this.Load += new System.EventHandler(this.FormFreelancer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderFreelancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).EndInit();
            this.groupBoxYouWallet.ResumeLayout(false);
            this.groupBoxYouWallet.PerformLayout();
            this.groupBoxInfoAboutYou.ResumeLayout(false);
            this.groupBoxInfoAboutYou.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLearnMore;
        private System.Windows.Forms.DataGridView dataGridViewOrderFreelancer;
        private System.Windows.Forms.Label labelYourOrder;
        private System.Windows.Forms.Button buttonMessageModerator;
        private System.Windows.Forms.GroupBox groupBoxYouWallet;
        private System.Windows.Forms.TextBox textBoxSumWallet;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label labelSumWallet;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.GroupBox groupBoxInfoAboutYou;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private FreelancerArticleBaseGridOrderCustomer freelancerArticleBaseGridOrderCustomer;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСимволовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бюджетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFeedback;
        private System.Windows.Forms.Button buttonFeedback;
    }
}