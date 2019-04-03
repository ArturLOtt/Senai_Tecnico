using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace InLock.DatabaseFirst.Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

// Scaffold-DbContext "Data Source=.\SqlExpress;Initial Catalog=InLock_Games_Manha; User Id=sa;pwd=132;"
//Microsoft.EntityFrameworkCore.SqlServer-OutputDir Domains -ContextDir Contexts -Context InLockContext

//    \\192.168.1.37\Dev\SegundoTermo2019\Bibliotecas
