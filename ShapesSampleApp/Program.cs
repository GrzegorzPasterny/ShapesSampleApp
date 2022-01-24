using Microsoft.Extensions.DependencyInjection;
using NLog;
using ShapesSampleApp.Actors;
using ShapesSampleApp.Models;
using ShapesSampleApp.Services;
using ShapesSampleAppLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesSampleApp
{
    // Points to be improved:
    // - more procese logging and handling of exceptions
    // - abstractions for the input and output services can be added, but for now other implementations are not forseen
    // - extract part of the code to library project
    // - add couple of more tests. Think if it is needed.
    // - think how to add more info via logger to Console, if this will not impact performance. To be tested...

    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider services = getStartupBuilder(args);

            Logger logger = (Logger)services.GetRequiredService(typeof(Logger));
            FlowActor flowActor = (FlowActor)services.GetRequiredService(typeof(FlowActor));
            
            logger.Info("Startup completed.");

            logger.Info("Starting execution...");
            flowActor.ProcessShapesXmlToTextFile();
            logger.Info("Flow has ended. Exiting the program...");
        }

        private static IServiceProvider getStartupBuilder(string[] args)
        {
            IServiceCollection services = new ServiceCollection()
                .AddSingleton(configureLogger())
                .AddSingleton(typeof(ShapesHelper))
                .AddSingleton(typeof(FlowActor))
                .AddSingleton(typeof(XmlService))
                .AddSingleton(typeof(Settings))
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
