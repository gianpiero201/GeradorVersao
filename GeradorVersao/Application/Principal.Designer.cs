namespace GeradorVersao
{
    partial class Principal
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbGerar = new System.Windows.Forms.TabPage();
            this.tbDeploy = new System.Windows.Forms.TabPage();
            this.tbProjetos = new System.Windows.Forms.TabPage();
            this.tbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbGerar);
            this.tbControl.Controls.Add(this.tbDeploy);
            this.tbControl.Controls.Add(this.tbProjetos);
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(286, 381);
            this.tbControl.TabIndex = 0;
            // 
            // tbGerar
            // 
            this.tbGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbGerar.Location = new System.Drawing.Point(4, 24);
            this.tbGerar.Name = "tbGerar";
            this.tbGerar.Padding = new System.Windows.Forms.Padding(3);
            this.tbGerar.Size = new System.Drawing.Size(278, 353);
            this.tbGerar.TabIndex = 0;
            this.tbGerar.Text = "Gerar";
            // 
            // tbDeploy
            // 
            this.tbDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDeploy.Location = new System.Drawing.Point(4, 24);
            this.tbDeploy.Name = "tbDeploy";
            this.tbDeploy.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeploy.Size = new System.Drawing.Size(278, 353);
            this.tbDeploy.TabIndex = 1;
            this.tbDeploy.Text = "Deploy";
            // 
            // tbProjetos
            // 
            this.tbProjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProjetos.Location = new System.Drawing.Point(4, 24);
            this.tbProjetos.Name = "tbProjetos";
            this.tbProjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tbProjetos.Size = new System.Drawing.Size(278, 353);
            this.tbProjetos.TabIndex = 2;
            this.tbProjetos.Text = "Projetos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(285, 380);
            this.Controls.Add(this.tbControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 419);
            this.MinimumSize = new System.Drawing.Size(301, 419);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Versão";
            this.tbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbControl;
        private TabPage tbGerar;
        private TabPage tbDeploy;
        private TabPage tbProjetos;
    }
}