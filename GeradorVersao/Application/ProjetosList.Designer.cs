namespace GeradorVersao.Application
{
    partial class ProjetosList
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
            this.DgvProjetos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.projetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAddProjeto = new System.Windows.Forms.Button();
            this.projetosContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProjetos
            // 
            this.DgvProjetos.AutoGenerateColumns = false;
            this.DgvProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.BtnEditar});
            this.DgvProjetos.DataSource = this.projetoBindingSource;
            this.DgvProjetos.Location = new System.Drawing.Point(3, 3);
            this.DgvProjetos.Name = "DgvProjetos";
            this.DgvProjetos.RowHeadersVisible = false;
            this.DgvProjetos.RowTemplate.Height = 25;
            this.DgvProjetos.Size = new System.Drawing.Size(272, 317);
            this.DgvProjetos.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // BtnEditar
            // 
            this.BtnEditar.FillWeight = 50.76142F;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.HeaderText = "Editar";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Editar";
            // 
            // projetoBindingSource
            // 
            this.projetoBindingSource.DataSource = typeof(GeradorVersao.Domain.Bd.Models.Projeto);
            // 
            // BtnAddProjeto
            // 
            this.BtnAddProjeto.Location = new System.Drawing.Point(3, 326);
            this.BtnAddProjeto.Name = "BtnAddProjeto";
            this.BtnAddProjeto.Size = new System.Drawing.Size(272, 23);
            this.BtnAddProjeto.TabIndex = 1;
            this.BtnAddProjeto.Text = "Adicionar Projeto";
            this.BtnAddProjeto.UseVisualStyleBackColor = true;
            this.BtnAddProjeto.Click += new System.EventHandler(this.BtnAddProjeto_Click);
            // 
            // ProjetosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BtnAddProjeto);
            this.Controls.Add(this.DgvProjetos);
            this.Name = "ProjetosList";
            this.Size = new System.Drawing.Size(278, 352);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DgvProjetos;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn BtnEditar;
        private BindingSource projetoBindingSource;
        private Button BtnAddProjeto;
        private BindingSource projetosContextBindingSource;
    }
}
