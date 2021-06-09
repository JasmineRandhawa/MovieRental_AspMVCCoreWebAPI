using System.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MovieRental.Models;

public class MyDbContext : DbContext
{
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
}