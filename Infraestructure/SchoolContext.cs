﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infraestructure
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("name = myContextDB")
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
