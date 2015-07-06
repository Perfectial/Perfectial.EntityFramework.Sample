using Perfectial.EntityFramework.Sample.DataAccess.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.DataAccess.Models
{
    public class School : BaseEntity
    {
        public string Name { get; set; }

        public string District { get; set; }

        public IList<Student> Students { get; set; }
    }
}
