using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt ) : base(opt)
        {
            
        }

        public DbSet<User> Users { get; set; }
    
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
    }
}