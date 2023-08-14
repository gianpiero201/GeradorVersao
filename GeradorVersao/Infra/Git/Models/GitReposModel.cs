using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorVersao.Infra.Git.Models
{
    public class GitReposModel
    {
        public string Path { get; set; } = null!;
        public Repository? Repos { get; set; }

    }
}
