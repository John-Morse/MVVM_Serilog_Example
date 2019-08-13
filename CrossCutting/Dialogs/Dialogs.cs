namespace MVVM_Template.CrossCutting
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Handles all generic Dialog boxes for the application.
    /// </summary>
    public class Dialogs
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Return types from dialog boxes
        /// </summary>
        public enum ReturnType
        {
            _none,
            Ok,
            Yes,
            No,
            Abort,
            Retry,
            Cancel,
            Ignore
        }

        #region Information

        /// <summary>
        /// Informational dialog
        /// </summary>
        /// <param name="infoMessage">string</param>Informational Message
        public static void Information(string infoMessage)
        {
            try
            {
                MessageBox.Show(infoMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.Info(infoMessage);
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }

        #endregion

        #region Warning

        /// <summary>
        /// Ok user related warning
        /// </summary>
        /// <param name="warningMessage">string</param>Warning Message
        public static void Warning(string warningMessage)
        {
            try
            {
                MessageBox.Show(warningMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                log.Warn(warningMessage);
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }

        /// <summary>
        /// Yes/No user related warning
        /// </summary>
        /// <param name="warningMessage">string</param>Warning Message
        /// <returns>ReturnType</returns>(enum) Return Type
        public static ReturnType WarningYesNo(string warningMessage)
        {
            try
            {
                if (MessageBox.Show(warningMessage, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    log.Warn(warningMessage);
                    return ReturnType.Yes;
                }
                else
                {
                    log.Warn(warningMessage);
                    return ReturnType.No;
                }
            }
            catch (Exception)
            {
                log.Warn(warningMessage);
                return ReturnType._none;
            }
            finally
            {
                
            }
        }

        #endregion

        #region Error

        /// <summary>
        /// Error dialog for system related errors
        /// </summary>
        /// <param name="e">Exception</param>Exception object
        public static void Error(Exception e)
        {
            try
            {
                MessageBox.Show("Message: " + e.Message + "\n\n" + "Calling Object: " + e.Source + "\n\n" +
                    "Stack Trace: " + e.StackTrace + "\n\n" + "Error Method: " + e.TargetSite + "\n\n" + "Inner Exception: " + e.InnerException, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                log.Error(e);
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }

        /// <summary>
        /// Error dialog for user related errors
        /// </summary>
        /// <param name="errorMessage">string</param>Error Message
        public static void ErrorUser(string errorMessage)
        {
            try
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(errorMessage);
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }

        /// <summary>
        /// Error dialog for user related errors
        /// </summary>
        /// <param name="errorMessage">string</param>Error Message
        public static void CustomErrorUser(string errorMessage, string caption)
        {
            try
            {
                MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(errorMessage);
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        #endregion              
                
    }
}
