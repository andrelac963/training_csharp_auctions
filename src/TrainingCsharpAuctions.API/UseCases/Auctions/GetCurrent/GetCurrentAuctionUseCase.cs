using Microsoft.EntityFrameworkCore;
using TrainingCsharpAuctions.API.Entities;
using TrainingCsharpAuctions.API.Repositories;

namespace TrainingCsharpAuctions.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new TrainingCsharpAuctionsDbContext();

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .First();
    }
}
