﻿namespace Demo.API
{
    using System;

    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    using Serilog;
    using Serilog.Events;

    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseSerilog().UseStartup<Startup>();
        }

        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().MinimumLevel
                .Override("Microsoft", LogEventLevel.Information).Enrich.FromLogContext()

                // .WriteTo.Console( )
                .CreateLogger();

            try
            {
                Log.Information("Starting web host");

                CreateWebHostBuilder(args).Build().Run();

                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}