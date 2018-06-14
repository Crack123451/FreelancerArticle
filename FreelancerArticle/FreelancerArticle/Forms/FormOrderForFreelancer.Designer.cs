namespace FreelancerArticle
{
    partial class FormOrderForFreelancer
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
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxCountSymbol = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelCountSymbol = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.buttonPublishWork = new System.Windows.Forms.Button();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.ItemHeight = 16;
            this.listBoxDescription.Location = new System.Drawing.Point(29, 164);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(398, 148);
            this.listBoxDescription.TabIndex = 21;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMoney.Location = new System.Drawing.Point(206, 383);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.ReadOnly = true;
            this.textBoxMoney.Size = new System.Drawing.Size(221, 27);
            this.textBoxMoney.TabIndex = 20;
            // 
            // textBoxCountSymbol
            // 
            this.textBoxCountSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountSymbol.Location = new System.Drawing.Point(206, 335);
            this.textBoxCountSymbol.Name = "textBoxCountSymbol";
            this.textBoxCountSymbol.ReadOnly = true;
            this.textBoxCountSymbol.Size = new System.Drawing.Size(221, 27);
            this.textBoxCountSymbol.TabIndex = 19;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(206, 83);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(221, 27);
            this.textBoxTitle.TabIndex = 18;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(24, 383);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(84, 24);
            this.labelMoney.TabIndex = 16;
            this.labelMoney.Text = "Бюджет";
            // 
            // labelCountSymbol
            // 
            this.labelCountSymbol.AutoSize = true;
            this.labelCountSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSymbol.Location = new System.Drawing.Point(24, 335);
            this.labelCountSymbol.Name = "labelCountSymbol";
            this.labelCountSymbol.Size = new System.Drawing.Size(164, 24);
            this.labelCountSymbol.TabIndex = 15;
            this.labelCountSymbol.Text = "Кол-во символов";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(24, 136);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(203, 24);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Подробное описание";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(24, 83);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 24);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Название";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopic.Location = new System.Drawing.Point(24, 31);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(56, 24);
            this.labelTopic.TabIndex = 12;
            this.labelTopic.Text = "Тема";
            // 
            // buttonPublishWork
            // 
            this.buttonPublishWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPublishWork.Location = new System.Drawing.Point(95, 442);
            this.buttonPublishWork.Name = "buttonPublishWork";
            this.buttonPublishWork.Size = new System.Drawing.Size(269, 55);
            this.buttonPublishWork.TabIndex = 22;
            this.buttonPublishWork.Text = "Прикрепить выполненную работу";
            this.buttonPublishWork.UseVisualStyleBackColor = true;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTopic.Location = new System.Drawing.Point(206, 31);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.ReadOnly = true;
            this.textBoxTopic.Size = new System.Drawing.Size(221, 27);
            this.textBoxTopic.TabIndex = 23;
            // 
            // FormOrderForFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 522);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.buttonPublishWork);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxCountSymbol);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelCountSymbol);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTopic);
            this.MaximizeBox = false;
            this.Name = "FormOrderForFreelancer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробнее о заказе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxDescription;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxCountSymbol;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelCountSymbol;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Button buttonPublishWork;
        private System.Windows.Forms.TextBox textBoxTopic;
    }
}