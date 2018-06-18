namespace FreelancerArticle
{
    partial class FormMessageForModerator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.freelancerArticleBaseDataForModerator = new FreelancerArticle.FreelancerArticleBaseDataForModerator();
            this.messengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messengerTableAdapter = new FreelancerArticle.FreelancerArticleBaseDataForModeratorTableAdapters.MessengerTableAdapter();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сообщениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseDataForModerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messengerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времяDataGridViewTextBoxColumn,
            this.логинПользователяDataGridViewTextBoxColumn,
            this.сообщениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messengerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(360, 265);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(136, 35);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // freelancerArticleBaseDataForModerator
            // 
            this.freelancerArticleBaseDataForModerator.DataSetName = "FreelancerArticleBaseDataForModerator";
            this.freelancerArticleBaseDataForModerator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messengerBindingSource
            // 
            this.messengerBindingSource.DataMember = "Messenger";
            this.messengerBindingSource.DataSource = this.freelancerArticleBaseDataForModerator;
            // 
            // messengerTableAdapter
            // 
            this.messengerTableAdapter.ClearBeforeFill = true;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.Frozen = true;
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время отправки";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.Width = 95;
            // 
            // логинПользователяDataGridViewTextBoxColumn
            // 
            this.логинПользователяDataGridViewTextBoxColumn.DataPropertyName = "Логин пользователя";
            this.логинПользователяDataGridViewTextBoxColumn.Frozen = true;
            this.логинПользователяDataGridViewTextBoxColumn.HeaderText = "Логин пользователя";
            this.логинПользователяDataGridViewTextBoxColumn.Name = "логинПользователяDataGridViewTextBoxColumn";
            this.логинПользователяDataGridViewTextBoxColumn.Width = 85;
            // 
            // сообщениеDataGridViewTextBoxColumn
            // 
            this.сообщениеDataGridViewTextBoxColumn.DataPropertyName = "Сообщение";
            this.сообщениеDataGridViewTextBoxColumn.Frozen = true;
            this.сообщениеDataGridViewTextBoxColumn.HeaderText = "Сообщение";
            this.сообщениеDataGridViewTextBoxColumn.Name = "сообщениеDataGridViewTextBoxColumn";
            this.сообщениеDataGridViewTextBoxColumn.Width = 400;
            // 
            // FormMessageForModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 321);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMessageForModerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сообщения модератору";
            this.Load += new System.EventHandler(this.FormMessageForModerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancerArticleBaseDataForModerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messengerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOK;
        private FreelancerArticleBaseDataForModerator freelancerArticleBaseDataForModerator;
        private System.Windows.Forms.BindingSource messengerBindingSource;
        private FreelancerArticleBaseDataForModeratorTableAdapters.MessengerTableAdapter messengerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сообщениеDataGridViewTextBoxColumn;
    }
}