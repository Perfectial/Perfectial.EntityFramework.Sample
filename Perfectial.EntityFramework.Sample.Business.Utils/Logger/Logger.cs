using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.Business.Utils
{
    public class Logger : ILogger
    {
        public Logger(string source) { }
        public Task Warn(string message)
        {
            throw new NotImplementedException();
        }

        public Task Inform(string message)
        {
            throw new NotImplementedException();
        }

        public Task Error(string message)
        {
            throw new NotImplementedException();
        }

        public Task Throw(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
