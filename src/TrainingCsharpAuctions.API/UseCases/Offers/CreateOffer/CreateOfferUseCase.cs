using TrainingCsharpAuctions.API.Communication.Requests;
using TrainingCsharpAuctions.API.Entities;
using TrainingCsharpAuctions.API.Repositories;
using TrainingCsharpAuctions.API.Services;

namespace TrainingCsharpAuctions.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    public CreateOfferUseCase(LoggedUser loggedUser)
    {
        _loggedUser = loggedUser;
    }
    
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new TrainingCsharpAuctionsDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id,
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
