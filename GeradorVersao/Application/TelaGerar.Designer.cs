namespace GeradorVersao.Application
{
    partial class TelaGerar
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
            this.LblProjeto = new System.Windows.Forms.Label();
            this.CbbProjetos = new System.Windows.Forms.ComboBox();
            this.LblVersao = new System.Windows.Forms.Label();
            this.TxtVersao = new System.Windows.Forms.TextBox();
            this.BtnVersaoSub = new System.Windows.Forms.Button();
            this.BtnVersaoAdd = new System.Windows.Forms.Button();
            this.BtnVerMinAdd = new System.Windows.Forms.Button();
            this.BtnVerMinSub = new System.Windows.Forms.Button();
            this.TxtVersaoMin = new System.Windows.Forms.TextBox();
            this.LblVerMin = new System.Windows.Forms.Label();
            this.LblTested = new System.Windows.Forms.Label();
            this.LblTestou = new System.Windows.Forms.Label();
            this.BtnTestar = new System.Windows.Forms.Button();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProjeto
            // 
            this.LblProjeto.AutoSize = true;
            this.LblProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblProjeto.Location = new System.Drawing.Point(3, 28);
            this.LblProjeto.Name = "LblProjeto";
            this.LblProjeto.Size = new System.Drawing.Size(48, 15);
            this.LblProjeto.TabIndex = 0;
            this.LblProjeto.Text = "Projeto:";
            // 
            // CbbProjetos
            // 
            this.CbbProjetos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CbbProjetos.FormattingEnabled = true;
            this.CbbProjetos.Location = new System.Drawing.Point(57, 25);
            this.CbbProjetos.Name = "CbbProjetos";
            this.CbbProjetos.Size = new System.Drawing.Size(218, 23);
            this.CbbProjetos.TabIndex = 1;
            // 
            // LblVersao
            // 
            this.LblVersao.AutoSize = true;
            this.LblVersao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblVersao.Location = new System.Drawing.Point(3, 63);
            this.LblVersao.Name = "LblVersao";
            this.LblVersao.Size = new System.Drawing.Size(44, 15);
            this.LblVersao.TabIndex = 2;
            this.LblVersao.Text = "Versão:";
            // 
            // TxtVersao
            // 
            this.TxtVersao.Enabled = false;
            this.TxtVersao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtVersao.Location = new System.Drawing.Point(57, 60);
            this.TxtVersao.Name = "TxtVersao";
            this.TxtVersao.Size = new System.Drawing.Size(163, 23);
            this.TxtVersao.TabIndex = 0;
            // 
            // BtnVersaoSub
            // 
            this.BtnVersaoSub.BackColor = System.Drawing.Color.DarkGray;
            this.BtnVersaoSub.FlatAppearance.BorderSize = 0;
            this.BtnVersaoSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVersaoSub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVersaoSub.Location = new System.Drawing.Point(226, 60);
            this.BtnVersaoSub.Name = "BtnVersaoSub";
            this.BtnVersaoSub.Size = new System.Drawing.Size(23, 23);
            this.BtnVersaoSub.TabIndex = 2;
            this.BtnVersaoSub.Text = "<";
            this.BtnVersaoSub.UseVisualStyleBackColor = false;
            // 
            // BtnVersaoAdd
            // 
            this.BtnVersaoAdd.BackColor = System.Drawing.Color.DarkGray;
            this.BtnVersaoAdd.FlatAppearance.BorderSize = 0;
            this.BtnVersaoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVersaoAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVersaoAdd.Location = new System.Drawing.Point(252, 60);
            this.BtnVersaoAdd.Name = "BtnVersaoAdd";
            this.BtnVersaoAdd.Size = new System.Drawing.Size(23, 23);
            this.BtnVersaoAdd.TabIndex = 3;
            this.BtnVersaoAdd.Text = ">";
            this.BtnVersaoAdd.UseVisualStyleBackColor = false;
            // 
            // BtnVerMinAdd
            // 
            this.BtnVerMinAdd.BackColor = System.Drawing.Color.DarkGray;
            this.BtnVerMinAdd.FlatAppearance.BorderSize = 0;
            this.BtnVerMinAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerMinAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVerMinAdd.Location = new System.Drawing.Point(252, 97);
            this.BtnVerMinAdd.Name = "BtnVerMinAdd";
            this.BtnVerMinAdd.Size = new System.Drawing.Size(23, 23);
            this.BtnVerMinAdd.TabIndex = 7;
            this.BtnVerMinAdd.Text = ">";
            this.BtnVerMinAdd.UseVisualStyleBackColor = false;
            // 
            // BtnVerMinSub
            // 
            this.BtnVerMinSub.BackColor = System.Drawing.Color.DarkGray;
            this.BtnVerMinSub.FlatAppearance.BorderSize = 0;
            this.BtnVerMinSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerMinSub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVerMinSub.Location = new System.Drawing.Point(226, 97);
            this.BtnVerMinSub.Name = "BtnVerMinSub";
            this.BtnVerMinSub.Size = new System.Drawing.Size(23, 23);
            this.BtnVerMinSub.TabIndex = 5;
            this.BtnVerMinSub.Text = "<";
            this.BtnVerMinSub.UseVisualStyleBackColor = false;
            // 
            // TxtVersaoMin
            // 
            this.TxtVersaoMin.Enabled = false;
            this.TxtVersaoMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtVersaoMin.Location = new System.Drawing.Point(57, 98);
            this.TxtVersaoMin.Name = "TxtVersaoMin";
            this.TxtVersaoMin.Size = new System.Drawing.Size(163, 23);
            this.TxtVersaoMin.TabIndex = 4;
            // 
            // LblVerMin
            // 
            this.LblVerMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblVerMin.Location = new System.Drawing.Point(3, 92);
            this.LblVerMin.Name = "LblVerMin";
            this.LblVerMin.Size = new System.Drawing.Size(55, 35);
            this.LblVerMin.TabIndex = 6;
            this.LblVerMin.Text = "Versão Mínima:";
            // 
            // LblTested
            // 
            this.LblTested.AutoSize = true;
            this.LblTested.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTested.Location = new System.Drawing.Point(1, 297);
            this.LblTested.Name = "LblTested";
            this.LblTested.Size = new System.Drawing.Size(50, 15);
            this.LblTested.TabIndex = 8;
            this.LblTested.Text = "Testado:";
            // 
            // LblTestou
            // 
            this.LblTestou.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTestou.Image = global::GeradorVersao.Properties.Resources.icons8_excluir;
            this.LblTestou.Location = new System.Drawing.Point(53, 297);
            this.LblTestou.Name = "LblTestou";
            this.LblTestou.Size = new System.Drawing.Size(16, 16);
            this.LblTestou.TabIndex = 9;
            // 
            // BtnTestar
            // 
            this.BtnTestar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnTestar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnTestar.FlatAppearance.BorderSize = 0;
            this.BtnTestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnTestar.Location = new System.Drawing.Point(4, 322);
            this.BtnTestar.Name = "BtnTestar";
            this.BtnTestar.Size = new System.Drawing.Size(75, 23);
            this.BtnTestar.TabIndex = 10;
            this.BtnTestar.Text = "Testar";
            this.BtnTestar.UseVisualStyleBackColor = false;
            this.BtnTestar.Click += new System.EventHandler(this.BtnTestar_Click);
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnGerar.FlatAppearance.BorderSize = 0;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGerar.Location = new System.Drawing.Point(200, 322);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(75, 23);
            this.BtnGerar.TabIndex = 11;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            // 
            // TelaGerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.BtnTestar);
            this.Controls.Add(this.LblTestou);
            this.Controls.Add(this.LblTested);
            this.Controls.Add(this.BtnVerMinAdd);
            this.Controls.Add(this.BtnVerMinSub);
            this.Controls.Add(this.TxtVersaoMin);
            this.Controls.Add(this.LblVerMin);
            this.Controls.Add(this.BtnVersaoAdd);
            this.Controls.Add(this.BtnVersaoSub);
            this.Controls.Add(this.TxtVersao);
            this.Controls.Add(this.LblVersao);
            this.Controls.Add(this.CbbProjetos);
            this.Controls.Add(this.LblProjeto);
            this.Name = "TelaGerar";
            this.Size = new System.Drawing.Size(278, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblProjeto;
        private ComboBox CbbProjetos;
        private Label LblVersao;
        private TextBox TxtVersao;
        private Button BtnVersaoSub;
        private Button BtnVersaoAdd;
        private Button BtnVerMinAdd;
        private Button BtnVerMinSub;
        private TextBox TxtVersaoMin;
        private Label LblVerMin;
        private Label LblTested;
        private Label LblTestou;
        private Button BtnTestar;
        private Button BtnGerar;
    }
}
