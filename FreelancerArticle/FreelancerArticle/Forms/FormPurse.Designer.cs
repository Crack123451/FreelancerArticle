namespace FreelancerArticle
{
    partial class FormPurse
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
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(61, 117);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(129, 35);
            this.buttonTransfer.TabIndex = 0;
            this.buttonTransfer.Text = "Перевести";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(92, 38);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(63, 20);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "Сумма";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(61, 74);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(129, 27);
            this.textBoxSum.TabIndex = 2;
            // 
            // FormPurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 184);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зачислить";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPurse_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxSum;
    }
}