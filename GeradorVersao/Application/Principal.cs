using GeradorVersao.Application;
using GeradorVersao.Infra.Git.Services.GitReposService;
using Newtonsoft.Json;

namespace GeradorVersao
{
    public partial class Principal : Form
    {
        private readonly IGitReposService GitReposService;
        public Principal(IGitReposService gitReposService)
        {
            InitializeComponent();
            GitReposService = gitReposService;
            LoadTabs();
        }

        public void LoadTabs()
        {
            tbGerar.Controls.Add(new TelaGerar());
            tbProjetos.Controls.Add(new ProjetosList());
        }
    }
}