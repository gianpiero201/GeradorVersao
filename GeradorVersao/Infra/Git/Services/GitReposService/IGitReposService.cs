using GeradorVersao.Infra.Git.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorVersao.Infra.Git.Services.GitReposService
{
    public interface IGitReposService
    {
        GitReposModel GetRepository(string url);
    }
}
