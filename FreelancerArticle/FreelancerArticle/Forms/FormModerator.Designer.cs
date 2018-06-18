namespace FreelancerArticle
{
    partial class FormModerator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewFreelancer = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.freelancerArticleBaseGridOrderCustomer = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomer();
            this.dataGridViewWallets = new System.Windows.Forms.DataGridView();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelFreelancer = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назначенныйФрилансерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бюджетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСимволовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTableAdapter = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter();
            this.freelancerArticleBaseDataForModerator = new FreelancerArticle.FreelancerArticleBaseDataForModerator();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new FreelancerArticle.FreelancerArticleBaseDataForModeratorTableAdapters.CustomerTableAdapter();
            this.freelancerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancerTableAdapter = new FreelancerArticle.FreelancerArticleBaseDataForModeratorTableAdapters.FreelancerTableAdapter();
            this.walletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletsTableAdapter = new FreelancerArticle.FreelancerArticleBaseDataForModeratorTableAdapters.WalletsTableAdapter();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кошелькаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кошелькаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кошелькаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreelancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseDataForModerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 1;
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
            // dataGridViewFreelancer
            // 
            this.dataGridViewFreelancer.AllowUserToAddRows = false;
            this.dataGridViewFreelancer.AllowUserToOrderColumns = true;
            this.dataGridViewFreelancer.AutoGenerateColumns = false;
            this.dataGridViewFreelancer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreelancer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логинDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.кошелькаDataGridViewTextBoxColumn1});
            this.dataGridViewFreelancer.DataSource = this.freelancerBindingSource;
            this.dataGridViewFreelancer.Location = new System.Drawing.Point(616, 91);
            this.dataGridViewFreelancer.Name = "dataGridViewFreelancer";
            this.dataGridViewFreelancer.RowTemplate.Height = 24;
            this.dataGridViewFreelancer.Size = new System.Drawing.Size(548, 210);
            this.dataGridViewFreelancer.TabIndex = 2;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToOrderColumns = true;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логинDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.кошелькаDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(23, 91);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(548, 210);
            this.dataGridViewCustomer.TabIndex = 3;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToOrderColumns = true;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.заказаDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоСимволовDataGridViewTextBoxColumn,
            this.бюджетDataGridViewTextBoxColumn,
            this.назначенныйФрилансерDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(23, 371);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(851, 210);
            this.dataGridViewOrder.TabIndex = 4;
            // 
            // freelancerArticleBaseGridOrderCustomer
            // 
            this.freelancerArticleBaseGridOrderCustomer.DataSetName = "FreelancerArticleBaseGridOrderCustomer";
            this.freelancerArticleBaseGridOrderCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewWallets
            // 
            this.dataGridViewWallets.AllowUserToAddRows = false;
            this.dataGridViewWallets.AllowUserToOrderColumns = true;
            this.dataGridViewWallets.AutoGenerateColumns = false;
            this.dataGridViewWallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кошелькаDataGridViewTextBoxColumn2,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridViewWallets.DataSource = this.walletsBindingSource;
            this.dataGridViewWallets.Location = new System.Drawing.Point(924, 371);
            this.dataGridViewWallets.Name = "dataGridViewWallets";
            this.dataGridViewWallets.RowTemplate.Height = 24;
            this.dataGridViewWallets.Size = new System.Drawing.Size(240, 210);
            this.dataGridViewWallets.TabIndex = 7;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessage.Location = new System.Drawing.Point(865, 606);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(299, 56);
            this.buttonMessage.TabIndex = 8;
            this.buttonMessage.Text = "Сообщения";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(18, 48);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(135, 29);
            this.labelCustomer.TabIndex = 9;
            this.labelCustomer.Text = "Заказчики";
            // 
            // labelFreelancer
            // 
            this.labelFreelancer.AutoSize = true;
            this.labelFreelancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFreelancer.Location = new System.Drawing.Point(611, 48);
            this.labelFreelancer.Name = "labelFreelancer";
            this.labelFreelancer.Size = new System.Drawing.Size(162, 29);
            this.labelFreelancer.TabIndex = 10;
            this.labelFreelancer.Text = "Фрилансеры";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.Location = new System.Drawing.Point(18, 329);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(96, 29);
            this.labelOrder.TabIndex = 11;
            this.labelOrder.Text = "Заказы";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWallet.Location = new System.Drawing.Point(919, 329);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(132, 29);
            this.labelWallet.TabIndex = 12;
            this.labelWallet.Text = "Кошельки";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.freelancerArticleBaseGridOrderCustomer;
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            this.состояниеDataGridViewTextBoxColumn.Width = 140;
            // 
            // назначенныйФрилансерDataGridViewTextBoxColumn
            // 
            this.назначенныйФрилансерDataGridViewTextBoxColumn.DataPropertyName = "Назначенный фрилансер";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.HeaderText = "Назначенный фрилансер";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.Name = "назначенныйФрилансерDataGridViewTextBoxColumn";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.Width = 80;
            // 
            // бюджетDataGridViewTextBoxColumn
            // 
            this.бюджетDataGridViewTextBoxColumn.DataPropertyName = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.HeaderText = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.Name = "бюджетDataGridViewTextBoxColumn";
            this.бюджетDataGridViewTextBoxColumn.Width = 50;
            // 
            // количествоСимволовDataGridViewTextBoxColumn
            // 
            this.количествоСимволовDataGridViewTextBoxColumn.DataPropertyName = "Количество символов";
            this.количествоСимволовDataGridViewTextBoxColumn.HeaderText = "Кол-во символов";
            this.количествоСимволовDataGridViewTextBoxColumn.Name = "количествоСимволовDataGridViewTextBoxColumn";
            this.количествоСимволовDataGridViewTextBoxColumn.Width = 60;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            this.заказчикDataGridViewTextBoxColumn.Width = 65;
            // 
            // заказаDataGridViewTextBoxColumn
            // 
            this.заказаDataGridViewTextBoxColumn.DataPropertyName = "№ Заказа";
            this.заказаDataGridViewTextBoxColumn.HeaderText = "№ Заказа";
            this.заказаDataGridViewTextBoxColumn.Name = "заказаDataGridViewTextBoxColumn";
            this.заказаDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // freelancerArticleBaseDataForModerator
            // 
            this.freelancerArticleBaseDataForModerator.DataSetName = "FreelancerArticleBaseDataForModerator";
            this.freelancerArticleBaseDataForModerator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.freelancerArticleBaseDataForModerator;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // freelancerBindingSource
            // 
            this.freelancerBindingSource.DataMember = "Freelancer";
            this.freelancerBindingSource.DataSource = this.freelancerArticleBaseDataForModerator;
            // 
            // freelancerTableAdapter
            // 
            this.freelancerTableAdapter.ClearBeforeFill = true;
            // 
            // walletsBindingSource
            // 
            this.walletsBindingSource.DataMember = "Wallets";
            this.walletsBindingSource.DataSource = this.freelancerArticleBaseDataForModerator;
            // 
            // walletsTableAdapter
            // 
            this.walletsTableAdapter.ClearBeforeFill = true;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.Width = 75;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 73;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 75;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 75;
            // 
            // кошелькаDataGridViewTextBoxColumn
            // 
            this.кошелькаDataGridViewTextBoxColumn.DataPropertyName = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn.HeaderText = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn.Name = "кошелькаDataGridViewTextBoxColumn";
            this.кошелькаDataGridViewTextBoxColumn.Width = 70;
            // 
            // логинDataGridViewTextBoxColumn1
            // 
            this.логинDataGridViewTextBoxColumn1.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn1.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn1.Name = "логинDataGridViewTextBoxColumn1";
            this.логинDataGridViewTextBoxColumn1.Width = 75;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.Width = 73;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 75;
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            this.отчествоDataGridViewTextBoxColumn1.Width = 75;
            // 
            // кошелькаDataGridViewTextBoxColumn1
            // 
            this.кошелькаDataGridViewTextBoxColumn1.DataPropertyName = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn1.HeaderText = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn1.Name = "кошелькаDataGridViewTextBoxColumn1";
            this.кошелькаDataGridViewTextBoxColumn1.Width = 70;
            // 
            // кошелькаDataGridViewTextBoxColumn2
            // 
            this.кошелькаDataGridViewTextBoxColumn2.DataPropertyName = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn2.Frozen = true;
            this.кошелькаDataGridViewTextBoxColumn2.HeaderText = "№ Кошелька";
            this.кошелькаDataGridViewTextBoxColumn2.Name = "кошелькаDataGridViewTextBoxColumn2";
            this.кошелькаDataGridViewTextBoxColumn2.Width = 70;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Frozen = true;
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 65;
            // 
            // FormModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1187, 674);
            this.Controls.Add(this.labelWallet);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelFreelancer);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.dataGridViewWallets);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.dataGridViewFreelancer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormModerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма модератора";
            this.Load += new System.EventHandler(this.FormModerator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreelancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseDataForModerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewFreelancer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewWallets;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelFreelancer;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelWallet;
        private FreelancerArticleBaseGridOrderCustomer freelancerArticleBaseGridOrderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСимволовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бюджетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назначенныйФрилансерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter orderTableAdapter;
        private FreelancerArticleBaseDataForModerator freelancerArticleBaseDataForModerator;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FreelancerArticleBaseDataForModeratorTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource freelancerBindingSource;
        private FreelancerArticleBaseDataForModeratorTableAdapters.FreelancerTableAdapter freelancerTableAdapter;
        private System.Windows.Forms.BindingSource walletsBindingSource;
        private FreelancerArticleBaseDataForModeratorTableAdapters.WalletsTableAdapter walletsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кошелькаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кошелькаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кошелькаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}