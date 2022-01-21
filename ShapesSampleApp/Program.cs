using Microsoft.Extensions.DependencyInjection;
using NLog;
using ShapesSampleApp.Actors;
using ShapesSampleApp.Services;
using ShapesSampleAppLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider services = getStartupBuilder(args);

            Logger logger = (Logger)services.GetRequiredService(typeof(Logger));

            logger.Info("Startup completed.");
        }

        private static IServiceProvider getStartupBuilder(string[] args)
        {
            IServiceCollection services = new ServiceCollection()
                .AddSingleton(configureLogger())
                .AddSingleton(typeof(ShapesHelper))
                .AddSingleton(typeof(FlowActor))
                .AddSingleton(typeof(XmlService))
                .AddSingleton(typeof(TextFileService))
                ;

            return services.BuildServiceProvider();
        }

        private static Logger configureLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            //var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            //config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;

            return LogManager.GetCurrentClassLogger();
        }
    }
}
