using File_Acess_Management.Data;
using File_Acess_Management.Data.Repository;
using File_Acess_Management.Data.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace File_Acess_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddSingleton<IDatabaseConnectionProvider, ConnectionHelper>();
            services.AddSingleton<ICommandFactory, ConnectionHelper>();
            services.AddScoped<ISoftwareRepository, SoftwareRepository>();
            services.AddScoped<IUserManagementRepository, UserManagementRepository>();
            services.AddScoped<IUserManagerAssignmentRepository, UserManagerAssignmentRepository>();
            services.AddScoped<IUserRaisedRequestRepository, UserRaisedRequestRepository>();
            services.AddScoped<IAdminRaisedRequest, AdminRaisedRequest>();
            services.AddScoped<IManagerSideRepository, ManagerSideRepository>();


            ServiceProvider serviceProvider = services.BuildServiceProvider();

            Application.Run(new UserLogin(serviceProvider));
            //Application.Run();
        }
    }
}
