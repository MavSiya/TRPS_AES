using AES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.EF
{
    class UsersContext : DbContext
    {
        public DbSet<Users> Phones { get; set; }
        public DbSet<Reports> Orders { get; set; }
        public UsersContext(DbContextOptions options)
        : base(options)
        {
        }

    }
}
