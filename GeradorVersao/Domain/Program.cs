using GeradorVersao.Infra.Git.Services.GitReposService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GeradorVersao.Domain
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<Principal>());
        }

        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IGitReposService, GitReposService>();
                    services.AddTransient<Principal>();
                });
        }
    }
}