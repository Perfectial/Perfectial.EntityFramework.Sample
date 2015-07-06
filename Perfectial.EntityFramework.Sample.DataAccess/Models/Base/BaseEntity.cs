using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.DataAccess.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool Deleted { get; set; }
    }
}
