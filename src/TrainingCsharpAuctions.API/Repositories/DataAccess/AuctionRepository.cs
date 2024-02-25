using Microsoft.EntityFrameworkCore;
using TrainingCsharpAuctions.API.Contracts;
using TrainingCsharpAuctions.API.Entities;
using TrainingCsharpAuctions.API.Repositories;

namespace TrainingCsharpAuctions.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly TrainingCsharpAuctionsDbContext _dbContext;
    public AuctionRepository(TrainingCsharpAuctionsDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
           .Auctions
           .Include(auction => auction.Items)
           .FirstOrDefault(auction => today >= auction.Starts);
    }
}