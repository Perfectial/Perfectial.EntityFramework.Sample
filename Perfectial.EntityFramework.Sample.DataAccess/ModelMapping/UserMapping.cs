﻿using Perfectial.EntityFramework.Sample.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectial.DataAccess.EntityFramework.DomainMapping
{
    /// <summary>
    /// Defines the convention-based mapping overrides for the User domain model. 
    /// </summary>
    public class UserFluentMap : EntityTypeConfiguration<Student>
    {
        public UserFluentMap()
        {
            Property(m => m.Name).IsRequired();
            Property(m => m.Email).IsRequired();
        }
    }
}
