using GeradorVersao.Infra.Git.Models;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorVersao.Infra.Git.Services.GitReposService
{
    public class GitReposService : IGitReposService
    {
        public GitReposModel GetRepository(string url)
        {
            var repositoryPath = Repository.Clone(url, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/VersionSystem", new CloneOptions
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = "giglio2001@gmail.com", Password = "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" }
            });
            var repos = new Repository(repositoryPath);

            Commands.Fetch(repos, "origin", new List<string>(), new FetchOptions(), "Fetch");

            return new GitReposModel
            {
                Path = repositoryPath,
                Repos = repos,
            };
        }
    }
}
