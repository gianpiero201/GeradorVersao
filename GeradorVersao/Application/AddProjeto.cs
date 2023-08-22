using GeradorVersao.Application.TiposArmazenamento;
using GeradorVersao.Application.Utils;
using GeradorVersao.Domain.Bd;
using GeradorVersao.Domain.Bd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorVersao.Application
{
    public partial class AddProjeto : Form
    {
        private string Caminho = string.Empty;

        public AddProjeto()
        {
            InitializeComponent();
            
        }

        private async void AddProjeto_Load(object sender, EventArgs e)
        {
            using (var db = new ProjetosContext())
            {
                await db.TipoArmazems.LoadAsync();
                TipoArmazemBS.DataSource = db.TipoArmazems.Local.ToBindingList();
            }
        }

        private void BtnCaminho_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Project Files (*.csproj)|*.csproj";

                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                TxtCaminho.Text = fileDialog.SafeFileName;

                if (string.IsNullOrWhiteSpace(TxtNomeProjeto.Text))
                {
                    TxtNomeProjeto.Text = fileDialog.SafeFileName.RemoverExtencao();
                }

                Caminho = fileDialog.FileName;
            }
        }

        private void CbbArmazem_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox? cbb = sender as ComboBox;
            TipoArmazem? tipo = cbb?.SelectedItem as TipoArmazem;

            if (tipo != null)
            {
                PnArmazemento.Controls.Clear();
                switch (tipo.Id)
                {
                    case 1:
                        break;
                    case 2:
                        PnArmazemento.Controls.Add(new Aws());
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
