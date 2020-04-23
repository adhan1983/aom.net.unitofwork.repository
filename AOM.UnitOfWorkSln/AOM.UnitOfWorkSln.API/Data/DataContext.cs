﻿using AOM.UnitOfWorkSln.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AOM.UnitOfWorkSln.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
