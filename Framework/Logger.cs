using System;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Framework
{
    public class Logger
    {

       
        public static log4net.Core.Level ClientErrorSendBackLevel = log4net.Core.Level.Off;

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        
        public static void Debug(string strMessage)
        {
            ILog logger = LogManager.GetLogger(string.Empty);
            if (logger != null && logger.IsDebugEnabled)
            {
                logger.Debug(strMessage);
            }
        }

        
        public static void Info(string strMessage)
        {
            ILog logger = LogManager.GetLogger(string.Empty);
            if (logger != null && logger.IsInfoEnabled)
            {
                logger.Info(strMessage);
            }
        }

        
        public static void Warn(string strMessage)
        {
            ILog logger = LogManager.GetLogger(string.Empty);
            if (logger != null && logger.IsWarnEnabled)
            {
                logger.Warn(strMessage);
            }
        }

       
        public static void Error(string strMessage)
        {
            ILog logger = LogManager.GetLogger(string.Empty);
            if (logger != null && logger.IsErrorEnabled)
            {
                logger.Error(strMessage);
            }
        }

        
        public static void Error(Exception ex)
        {
            Error(ex.ToString());
        }
    }
}
