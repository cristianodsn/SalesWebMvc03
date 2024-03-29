﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc03.Models;

namespace SalesWebMvc03.Data
{
    public class SalesWebMvc03Context : DbContext
    {
        public SalesWebMvc03Context (DbContextOptions<SalesWebMvc03Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord{ get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
    }
}
