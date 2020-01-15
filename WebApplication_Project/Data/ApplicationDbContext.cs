using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_Project.Models;

namespace WebApplication_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }


        public DbSet<Games> gSGames { get; set; }
        public DbSet<Users> gSUsers { get; set; }
        public DbSet<Orders> gSOrders { get; set; }
    }

    
}
