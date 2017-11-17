using System;
using System.Text;

namespace Logger.CL
{
    internal static class LogBuilder
    {
        internal static string Build(string className,
            string methodName,
            Exception ex)
        {

            var exceptionMessage = (ex.InnerException != null) 
                ? ex.InnerException.Message : ex.Message;

            //Build content
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Class: " + className);
            sb.AppendLine("Method: " + methodName);
            sb.AppendLine("Date Added: " + DateTime.Now.ToString());
            sb.AppendLine("Exception: " + exceptionMessage);

            return sb.ToString();
        }
    }
}
