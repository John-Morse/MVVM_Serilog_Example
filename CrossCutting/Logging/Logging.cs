namespace MVVM_Serilog.CrossCutting
{
    using Serilog;
    using System;

    /// <summary>
    /// Logging management and settings (Serilog)
    /// </summary>
    public class Logging
    {
        /// <summary>
        /// Configure Serilog for application
        /// </summary>
        public static void ConfigureSerilog()
        {
            try
            {
                //configure Serilog
                Log.Logger = new LoggerConfiguration().ReadFrom.AppSettings().CreateLogger();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
