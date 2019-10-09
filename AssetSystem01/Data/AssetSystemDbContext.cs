using AssetSystem01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetSystem01.Data
{
    public class AssetSystemDbContext : DbContext
    {
        public AssetSystemDbContext(DbContextOptions<AssetSystemDbContext> options)
           : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
