using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}