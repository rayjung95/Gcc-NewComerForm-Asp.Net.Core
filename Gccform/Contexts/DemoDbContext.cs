using System;
using Gccform.Models;
using Microsoft.EntityFrameworkCore;

namespace Gccform.Contexts
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Church> Churches { get; set; }
        public DbSet<PersonName> PersonNames { get; set; }




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);
		}
	}
}
