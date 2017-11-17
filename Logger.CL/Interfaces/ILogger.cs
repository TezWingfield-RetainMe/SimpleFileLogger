using System;
using System.Threading.Tasks;

namespace Logger.CL.Interfaces
{
    public interface ILogger
    {
        Task Log(string className,
            string methodName,
                Exception exception);
    }
}
