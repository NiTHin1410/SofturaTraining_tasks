using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Simple_Activity_2.Models
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext()
        {

        }
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ASHWIN;Database=Trial;Integrated Security=True");
        }
        public virtual DbSet<Customer> Customers { get; set; }

    }
}
