using employee_payroll.Data;
using employee_payroll.IRepositories;
using employee_payroll.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace employee_payroll
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Build the host
            var host = Host.CreateDefaultBuilder()
                
                .ConfigureServices((context, services) =>
                {
                    // Configure DbContext
                    string connectionString = "server=localhost;database=employee_payroll_db;user=root;password=";

                    services.AddDbContext<ApplicationDbContext>(options =>
                    {
                        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                    }, ServiceLifetime.Singleton);

                    // Register repositories
                    services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
                    services.AddSingleton<IPayrollRepository, PayrollRepository>();

                    // Register Form1 so DI can create it
                    services.AddSingleton<Form1>();
                })
                .Build();

            // Get Form1 from DI
            var form1 = host.Services.GetRequiredService<Form1>();

            Application.Run(form1);
        }
    }
}
