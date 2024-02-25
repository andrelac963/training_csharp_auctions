using TrainingCsharpAuctions.API.Contracts;
using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly TrainingCsharpAuctionsDbContext _dbContext;
    public OfferRepository(TrainingCsharpAuctionsDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}