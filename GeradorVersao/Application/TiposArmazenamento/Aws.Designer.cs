namespace GeradorVersao.Application.TiposArmazenamento
{
    partial class Aws
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblBucketS3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.armazemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.armazemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBucketS3
            // 
            this.LblBucketS3.AutoSize = true;
            this.LblBucketS3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblBucketS3.Location = new System.Drawing.Point(3, 25);
            this.LblBucketS3.Name = "LblBucketS3";
            this.LblBucketS3.Size = new System.Drawing.Size(61, 15);
            this.LblBucketS3.TabIndex = 0;
            this.LblBucketS3.Text = "Bucket S3:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.armazemBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            // 
            // armazemBindingSource
            // 
            this.armazemBindingSource.DataSource = typeof(GeradorVersao.Domain.Bd.Models.Armazem);
            // 
            // Aws
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblBucketS3);
            this.Name = "Aws";
            this.Size = new System.Drawing.Size(272, 68);
            ((System.ComponentModel.ISupportInitialize)(this.armazemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblBucketS3;
        private ComboBox comboBox1;
        private BindingSource armazemBindingSource;
    }
}
