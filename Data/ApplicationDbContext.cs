using Auctions.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Table pour les annonces
        public DbSet<Listing> Listings { get; set; }

        // Table pour les enchères
        public DbSet<Bid> Bids { get; set; }

        // Table pour les commentaires
        public DbSet<Comment> Comments { get; set; }
    }
}
    
