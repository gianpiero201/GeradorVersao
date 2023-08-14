using GeradorVersao.Infra.Git.Services.GitReposService;
using Newtonsoft.Json;

namespace GeradorVersao
{
    public partial class Form1 : Form
    {
        private readonly IGitReposService GitReposService;
        public Form1(IGitReposService gitReposService)
        {
            InitializeComponent();
            GitReposService = gitReposService;
        }

        private void btnGian_Click(object sender, EventArgs e)
        {
            JsonConvert.SerializeObject(GitReposService.GetRepository("https://github.com/gianpiero201/ChatApp.git"));
        }
    }
}