using Microsoft.EntityFrameworkCore;
using equb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace equb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Equb_detail> Equb_detail { get; set; }
        public DbSet<Equb_order> Equb_order { get; set; }
        public DbSet<Reserves> Reserves { get; set; }
        public DbSet<Transact> Transact { get; set; }
    }
}
