namespace FreelancerArticle
{
    partial class FormFile
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
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFile.Location = new System.Drawing.Point(28, 75);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(401, 27);
            this.textBoxFile.TabIndex = 5;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.Location = new System.Drawing.Point(153, 32);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(147, 20);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "Ссылка на файл";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(157, 124);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(143, 35);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 183);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл";
            this.Load += new System.EventHandler(this.FormFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOK;
    }
}