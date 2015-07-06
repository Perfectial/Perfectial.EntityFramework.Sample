using Perfectial.EntityFramework.Sample.DataAccess.Models.Base;
using Perfectial.EntityFramework.Sample.DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.DataAccess.Models
{
    public class Student : BaseEntity
    {
        #region Properties
        public string Name { get; set; }

        public string Email { get; set; }

        public StudentType Type { get; set; }
        #endregion

        #region References
        public School School { get; set; }
        #endregion
    }
}
