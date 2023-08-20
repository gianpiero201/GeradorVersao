using GeradorVersao.Properties;
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
    public partial class TelaGerar : UserControl
    {
        private bool Tested { get; set; } = false;
        public TelaGerar()
        {
            InitializeComponent();
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            LblTestou.Image = Resources.icons8_selecionado;
        }
    }
}
