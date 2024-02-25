using TrainingCsharpAuctions.API.Entities;

namespace TrainingCsharpAuctions.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}