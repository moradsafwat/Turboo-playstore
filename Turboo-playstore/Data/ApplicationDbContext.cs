using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Turboo_playstore.Models;

namespace Turboo_playstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Invoice>()
                .HasOne(c => c.Customer)
                .WithMany(i => i.Invoices)
                .HasForeignKey(f => f.CustomerId);

            builder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(f => f.CategoryId);

            builder.Entity<InvoiceDetails>()
                .HasOne(i => i.Invoice)
                .WithMany(d => d.InvoicesDetails)
                .HasForeignKey(f => f.InvoiceId);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceDetails> InvoicesDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
