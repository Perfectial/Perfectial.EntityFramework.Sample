using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.Business.Utils.Mapper
{
    public static class Mapper
    {
        public static TResult Map<TResult>(object source)
            where TResult : class
        {
            throw new NotImplementedException();
        }

        public static TResult MapContents<TSource, TResult>(TSource source, TResult destination)
            where TResult : class
            where TSource : class
        {
            throw new NotImplementedException();
        }
    }
}
