﻿using System;
using Budgeter.Domain.EF.Configuration;
using Budgeter.Domain.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Budgeter.Domain.EF
{
    public class BudgeterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=ROCKET;Initial Catalog=BudgeterCore;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseMap<ResourceDelta, ResourceDeltaMap>();
        }
    }
}
