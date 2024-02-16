using Microsoft.EntityFrameworkCore;
using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Repositories;

public class TrainingCsharpAuctionsDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\dtiDigital\\OneDrive - dti digital crafters\\Documentos\\leilaoDbNLW.db");
    }
}
