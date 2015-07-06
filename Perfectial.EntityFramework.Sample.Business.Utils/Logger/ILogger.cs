using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.Business.Utils
{
    public interface ILogger
    {
        Task Warn(string message);
        Task Inform(string message);
        Task Error(string message);
        Task Throw(Exception ex);
    }
}
