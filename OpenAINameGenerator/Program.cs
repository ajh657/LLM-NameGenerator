using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenAINameGenerator.OPassowrd;
using OpenAINameGenerator.OpenAI;

namespace OpenAINameGenerator
{
    public static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; } = null!;

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
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Add services to the container.
                services.AddTransient<IOPIntegration, OPIntegration>();
                services.AddTransient<IOpenAIClient, OpenAIClient>();
                services.AddTransient<MainForm>();
            });
        }

    }
}
