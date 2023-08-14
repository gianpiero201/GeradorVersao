namespace GeradorVersao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGian = new System.Windows.Forms.Button();
            this.lblJson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGian
            // 
            this.btnGian.Location = new System.Drawing.Point(700, 28);
            this.btnGian.Name = "btnGian";
            this.btnGian.Size = new System.Drawing.Size(75, 23);
            this.btnGian.TabIndex = 0;
            this.btnGian.Text = "Rodar";
            this.btnGian.UseVisualStyleBackColor = true;
            this.btnGian.Click += new System.EventHandler(this.btnGian_Click);
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(12, 28);
            this.lblJson.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(13, 15);
            this.lblJson.TabIndex = 1;
            this.lblJson.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJson);
            this.Controls.Add(this.btnGian);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGian;
        private Label lblJson;
    }
}