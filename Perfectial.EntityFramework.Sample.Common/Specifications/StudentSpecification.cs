using Perfectial.EntityFramework.Sample.Common.Specifications.Base;
using Perfectial.EntityFramework.Sample.DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.EntityFramework.Sample.Common.DTOs
{
    public class StudentSpecification : BaseSpecification
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public StudentType Type { get; set; }
    }
}
