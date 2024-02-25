using Microsoft.EntityFrameworkCore;
using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Repositories;

public class TrainingCsharpAuctionsDbContext : DbContext
{
    public TrainingCsharpAuctionsDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
