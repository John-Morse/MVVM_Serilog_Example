namespace MVVM_Serilog.CrossCutting
{
    using System;

    /// <summary>
    /// Logging management and settings (log4net)
    /// </summary>
    public class Logging
    {
        //set the logger
       // private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        /// <summary>
        /// Configure log4net for application
        /// </summary>
        public static void ConfigureLog4Net()
        {
            try
            {
                //get the log4net config file and configure
               // log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
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
