namespace FreelancerArticle
{
    partial class FormClient
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
            this.groupBoxInfoAboutYou = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxInfoAboutFreelancer = new System.Windows.Forms.GroupBox();
            this.listBoxFeedback = new System.Windows.Forms.ListBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.groupBoxYouWallet = new System.Windows.Forms.GroupBox();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.textBoxSumWallet = new System.Windows.Forms.TextBox();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.labelSumWallet = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.buttonMessageModerator = new System.Windows.Forms.Button();
            this.labelYourOrder = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLookAt = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonConfirmWork = new System.Windows.Forms.Button();
            this.buttonGiveReview = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.заказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСимволовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бюджетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назначенныйФрилансерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancerArticleBaseGridOrderCustomer = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomer();
            this.orderTableAdapter = new FreelancerArticle.FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter();
            this.buttonConflict = new System.Windows.Forms.Button();
            this.groupBoxInfoAboutYou.SuspendLayout();
            this.groupBoxInfoAboutFreelancer.SuspendLayout();
            this.groupBoxYouWallet.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxInfoAboutYou.Location = new System.Drawing.Point(22, 42);
            this.groupBoxInfoAboutYou.Name = "groupBoxInfoAboutYou";
            this.groupBoxInfoAboutYou.Size = new System.Drawing.Size(255, 170);
            this.groupBoxInfoAboutYou.TabIndex = 0;
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
            // groupBoxInfoAboutFreelancer
            // 
            this.groupBoxInfoAboutFreelancer.Controls.Add(this.listBoxFeedback);
            this.groupBoxInfoAboutFreelancer.Controls.Add(this.buttonChoose);
            this.groupBoxInfoAboutFreelancer.Controls.Add(this.buttonReviews);
            this.groupBoxInfoAboutFreelancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfoAboutFreelancer.Location = new System.Drawing.Point(351, 42);
            this.groupBoxInfoAboutFreelancer.Name = "groupBoxInfoAboutFreelancer";
            this.groupBoxInfoAboutFreelancer.Size = new System.Drawing.Size(255, 252);
            this.groupBoxInfoAboutFreelancer.TabIndex = 1;
            this.groupBoxInfoAboutFreelancer.TabStop = false;
            this.groupBoxInfoAboutFreelancer.Text = "Отклики на заказ";
            // 
            // listBoxFeedback
            // 
            this.listBoxFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFeedback.FormattingEnabled = true;
            this.listBoxFeedback.ItemHeight = 22;
            this.listBoxFeedback.Location = new System.Drawing.Point(23, 31);
            this.listBoxFeedback.Name = "listBoxFeedback";
            this.listBoxFeedback.Size = new System.Drawing.Size(209, 114);
            this.listBoxFeedback.TabIndex = 7;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(14, 204);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(226, 34);
            this.buttonChoose.TabIndex = 6;
            this.buttonChoose.Text = "Подробнее о фрилансере";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonReviews
            // 
            this.buttonReviews.Location = new System.Drawing.Point(70, 166);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(121, 32);
            this.buttonReviews.TabIndex = 5;
            this.buttonReviews.Text = "Отзывы";
            this.buttonReviews.UseVisualStyleBackColor = true;
            this.buttonReviews.Click += new System.EventHandler(this.buttonReviews_Click);
            // 
            // groupBoxYouWallet
            // 
            this.groupBoxYouWallet.Controls.Add(this.buttonMoney);
            this.groupBoxYouWallet.Controls.Add(this.textBoxSumWallet);
            this.groupBoxYouWallet.Controls.Add(this.textBoxWallet);
            this.groupBoxYouWallet.Controls.Add(this.labelSumWallet);
            this.groupBoxYouWallet.Controls.Add(this.labelWallet);
            this.groupBoxYouWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxYouWallet.Location = new System.Drawing.Point(680, 42);
            this.groupBoxYouWallet.Name = "groupBoxYouWallet";
            this.groupBoxYouWallet.Size = new System.Drawing.Size(255, 149);
            this.groupBoxYouWallet.TabIndex = 2;
            this.groupBoxYouWallet.TabStop = false;
            this.groupBoxYouWallet.Text = "Ваш кошелек";
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(69, 106);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(121, 32);
            this.buttonMoney.TabIndex = 7;
            this.buttonMoney.Text = "Зачислить";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
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
            // buttonMessageModerator
            // 
            this.buttonMessageModerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessageModerator.Location = new System.Drawing.Point(680, 246);
            this.buttonMessageModerator.Name = "buttonMessageModerator";
            this.buttonMessageModerator.Size = new System.Drawing.Size(255, 41);
            this.buttonMessageModerator.TabIndex = 7;
            this.buttonMessageModerator.Text = "Написать модератору";
            this.buttonMessageModerator.UseVisualStyleBackColor = true;
            this.buttonMessageModerator.Click += new System.EventHandler(this.buttonMessageModerator_Click);
            // 
            // labelYourOrder
            // 
            this.labelYourOrder.AutoSize = true;
            this.labelYourOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourOrder.Location = new System.Drawing.Point(16, 261);
            this.labelYourOrder.Name = "labelYourOrder";
            this.labelYourOrder.Size = new System.Drawing.Size(189, 32);
            this.labelYourOrder.TabIndex = 8;
            this.labelYourOrder.Text = "Ваши заказы";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(771, 570);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 41);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLookAt
            // 
            this.buttonLookAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLookAt.Location = new System.Drawing.Point(594, 570);
            this.buttonLookAt.Name = "buttonLookAt";
            this.buttonLookAt.Size = new System.Drawing.Size(148, 41);
            this.buttonLookAt.TabIndex = 11;
            this.buttonLookAt.Text = "Просмотр";
            this.buttonLookAt.UseVisualStyleBackColor = true;
            this.buttonLookAt.Click += new System.EventHandler(this.buttonLookAt_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(413, 570);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 41);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonConfirmWork
            // 
            this.buttonConfirmWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmWork.Location = new System.Drawing.Point(40, 629);
            this.buttonConfirmWork.Name = "buttonConfirmWork";
            this.buttonConfirmWork.Size = new System.Drawing.Size(231, 41);
            this.buttonConfirmWork.TabIndex = 13;
            this.buttonConfirmWork.Text = "Подтвердить работу";
            this.buttonConfirmWork.UseVisualStyleBackColor = true;
            this.buttonConfirmWork.Click += new System.EventHandler(this.buttonConfirmWork_Click);
            // 
            // buttonGiveReview
            // 
            this.buttonGiveReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGiveReview.Location = new System.Drawing.Point(40, 570);
            this.buttonGiveReview.Name = "buttonGiveReview";
            this.buttonGiveReview.Size = new System.Drawing.Size(231, 41);
            this.buttonGiveReview.TabIndex = 14;
            this.buttonGiveReview.Text = "Оставить отзыв";
            this.buttonGiveReview.UseVisualStyleBackColor = true;
            this.buttonGiveReview.Click += new System.EventHandler(this.buttonGiveReview_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 17;
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
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.заказаDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоСимволовDataGridViewTextBoxColumn,
            this.бюджетDataGridViewTextBoxColumn,
            this.назначенныйФрилансерDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(22, 300);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(913, 264);
            this.dataGridViewOrder.TabIndex = 18;
            this.dataGridViewOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            this.названиеDataGridViewTextBoxColumn.Width = 160;
            // 
            // количествоСимволовDataGridViewTextBoxColumn
            // 
            this.количествоСимволовDataGridViewTextBoxColumn.DataPropertyName = "Количество символов";
            this.количествоСимволовDataGridViewTextBoxColumn.Frozen = true;
            this.количествоСимволовDataGridViewTextBoxColumn.HeaderText = "Кол-во символов";
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
            // назначенныйФрилансерDataGridViewTextBoxColumn
            // 
            this.назначенныйФрилансерDataGridViewTextBoxColumn.DataPropertyName = "Назначенный фрилансер";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.Frozen = true;
            this.назначенныйФрилансерDataGridViewTextBoxColumn.HeaderText = "Назначенный фрилансер";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.Name = "назначенныйФрилансерDataGridViewTextBoxColumn";
            this.назначенныйФрилансерDataGridViewTextBoxColumn.ReadOnly = true;
            this.назначенныйФрилансерDataGridViewTextBoxColumn.Width = 80;
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
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // buttonConflict
            // 
            this.buttonConflict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConflict.Location = new System.Drawing.Point(780, 199);
            this.buttonConflict.Name = "buttonConflict";
            this.buttonConflict.Size = new System.Drawing.Size(155, 41);
            this.buttonConflict.TabIndex = 19;
            this.buttonConflict.Text = "Конфликт";
            this.buttonConflict.UseVisualStyleBackColor = true;
            this.buttonConflict.Click += new System.EventHandler(this.buttonConflict_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(957, 682);
            this.Controls.Add(this.buttonConflict);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonGiveReview);
            this.Controls.Add(this.buttonConfirmWork);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLookAt);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelYourOrder);
            this.Controls.Add(this.buttonMessageModerator);
            this.Controls.Add(this.groupBoxYouWallet);
            this.Controls.Add(this.groupBoxInfoAboutFreelancer);
            this.Controls.Add(this.groupBoxInfoAboutYou);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма заказчика";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.groupBoxInfoAboutYou.ResumeLayout(false);
            this.groupBoxInfoAboutYou.PerformLayout();
            this.groupBoxInfoAboutFreelancer.ResumeLayout(false);
            this.groupBoxYouWallet.ResumeLayout(false);
            this.groupBoxYouWallet.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseGridOrderCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfoAboutYou;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.GroupBox groupBoxInfoAboutFreelancer;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.GroupBox groupBoxYouWallet;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label labelSumWallet;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonMessageModerator;
        private System.Windows.Forms.Label labelYourOrder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLookAt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonConfirmWork;
        private System.Windows.Forms.Button buttonGiveReview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        internal System.Windows.Forms.TextBox textBoxSumWallet;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private FreelancerArticleBaseGridOrderCustomer freelancerArticleBaseGridOrderCustomer;
        private FreelancerArticleBaseGridOrderCustomerTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСимволовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бюджетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назначенныйФрилансерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBoxFeedback;
        private System.Windows.Forms.Button buttonConflict;
    }
}