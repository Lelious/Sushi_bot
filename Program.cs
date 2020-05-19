using System;
using System.Windows.Forms;
using Serilog;

namespace Sushi_bot
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .Enrich.FromLogContext()             
               .WriteTo.File($"logs\\log.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 30000)
               .CreateLogger();

            Log.Information($"Starting program: {Application.CompanyName}, number of Therad : {AppDomain.GetCurrentThreadId()}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SushiBot());
        }
    }
}
