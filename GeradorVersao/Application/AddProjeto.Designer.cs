namespace GeradorVersao.Application
{
    partial class AddProjeto
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
            this.LblNomeProj = new System.Windows.Forms.Label();
            this.TxtNomeProjeto = new System.Windows.Forms.TextBox();
            this.TxtCaminho = new System.Windows.Forms.TextBox();
            this.LblCaminho = new System.Windows.Forms.Label();
            this.BtnCaminho = new System.Windows.Forms.Button();
            this.LblTipoArmazem = new System.Windows.Forms.Label();
            this.CbbArmazem = new System.Windows.Forms.ComboBox();
            this.TipoArmazemBS = new System.Windows.Forms.BindingSource(this.components);
            this.PnArmazemento = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TipoArmazemBS)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeProj
            // 
            this.LblNomeProj.AutoSize = true;
            this.LblNomeProj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNomeProj.Location = new System.Drawing.Point(2, 18);
            this.LblNomeProj.Name = "LblNomeProj";
            this.LblNomeProj.Size = new System.Drawing.Size(43, 15);
            this.LblNomeProj.TabIndex = 0;
            this.LblNomeProj.Text = "Nome:";
            // 
            // TxtNomeProjeto
            // 
            this.TxtNomeProjeto.Location = new System.Drawing.Point(51, 15);
            this.TxtNomeProjeto.Name = "TxtNomeProjeto";
            this.TxtNomeProjeto.Size = new System.Drawing.Size(224, 23);
            this.TxtNomeProjeto.TabIndex = 1;
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.Enabled = false;
            this.TxtCaminho.Location = new System.Drawing.Point(67, 56);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.Size = new System.Drawing.Size(179, 23);
            this.TxtCaminho.TabIndex = 3;
            // 
            // LblCaminho
            // 
            this.LblCaminho.AutoSize = true;
            this.LblCaminho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCaminho.Location = new System.Drawing.Point(2, 59);
            this.LblCaminho.Name = "LblCaminho";
            this.LblCaminho.Size = new System.Drawing.Size(59, 15);
            this.LblCaminho.TabIndex = 2;
            this.LblCaminho.Text = "Caminho:";
            // 
            // BtnCaminho
            // 
            this.BtnCaminho.BackColor = System.Drawing.Color.Transparent;
            this.BtnCaminho.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaminho.Image = global::GeradorVersao.Properties.Resources.icons8_pesquisar;
            this.BtnCaminho.Location = new System.Drawing.Point(252, 55);
            this.BtnCaminho.Name = "BtnCaminho";
            this.BtnCaminho.Size = new System.Drawing.Size(23, 23);
            this.BtnCaminho.TabIndex = 4;
            this.BtnCaminho.UseVisualStyleBackColor = false;
            this.BtnCaminho.Click += new System.EventHandler(this.BtnCaminho_Click);
            // 
            // LblTipoArmazem
            // 
            this.LblTipoArmazem.AutoSize = true;
            this.LblTipoArmazem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTipoArmazem.Location = new System.Drawing.Point(3, 100);
            this.LblTipoArmazem.Name = "LblTipoArmazem";
            this.LblTipoArmazem.Size = new System.Drawing.Size(61, 15);
            this.LblTipoArmazem.TabIndex = 5;
            this.LblTipoArmazem.Text = "Armazem:";
            // 
            // CbbArmazem
            // 
            this.CbbArmazem.DataSource = this.TipoArmazemBS;
            this.CbbArmazem.DisplayMember = "Nome";
            this.CbbArmazem.FormattingEnabled = true;
            this.CbbArmazem.Location = new System.Drawing.Point(67, 97);
            this.CbbArmazem.Name = "CbbArmazem";
            this.CbbArmazem.Size = new System.Drawing.Size(208, 23);
            this.CbbArmazem.TabIndex = 6;
            this.CbbArmazem.Tag = "1";
            this.CbbArmazem.ValueMember = "Id";
            this.CbbArmazem.SelectedValueChanged += new System.EventHandler(this.CbbArmazem_SelectedValueChanged);
            // 
            // TipoArmazemBS
            // 
            this.TipoArmazemBS.DataSource = typeof(GeradorVersao.Domain.Bd.Models.TipoArmazem);
            // 
            // PnArmazemento
            // 
            this.PnArmazemento.Location = new System.Drawing.Point(3, 126);
            this.PnArmazemento.Name = "PnArmazemento";
            this.PnArmazemento.Size = new System.Drawing.Size(272, 132);
            this.PnArmazemento.TabIndex = 7;
            // 
            // AddProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.PnArmazemento);
            this.Controls.Add(this.CbbArmazem);
            this.Controls.Add(this.LblTipoArmazem);
            this.Controls.Add(this.BtnCaminho);
            this.Controls.Add(this.TxtCaminho);
            this.Controls.Add(this.LblCaminho);
            this.Controls.Add(this.TxtNomeProjeto);
            this.Controls.Add(this.LblNomeProj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(297, 300);
            this.Name = "AddProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoArmazemBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNomeProj;
        private TextBox TxtNomeProjeto;
        private TextBox TxtCaminho;
        private Label LblCaminho;
        private Button BtnCaminho;
        private Label LblTipoArmazem;
        private ComboBox CbbArmazem;
        private BindingSource TipoArmazemBS;
        private Panel PnArmazemento;
    }
}
