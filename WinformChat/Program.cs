using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinformsChat.Repositories;
using WinformsChat;
using WinformChat;

namespace WinformsChat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<InputWindow>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            string connectionString = "Data Source=sqlsrv;Initial Catalog=asdasd;User ID=admin;Password=123;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IUserRepository, UserRepository>(provider => new UserRepository(connectionString));

                    services.AddTransient<InputWindow>();
                    services.AddTransient<RegistrationForm>();
                    services.AddTransient<AuthorizeForm>();
                    services.AddTransient<Chat>();
                });
        }
    }
}