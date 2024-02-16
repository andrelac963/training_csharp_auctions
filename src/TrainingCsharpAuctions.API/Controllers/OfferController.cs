using Microsoft.AspNetCore.Mvc;
using TrainingCsharpAuctions.API.Communication.Requests;
using TrainingCsharpAuctions.API.Filters;
using TrainingCsharpAuctions.API.UseCases.Offers.CreateOffer;

namespace TrainingCsharpAuctions.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : TrainingCsharpAuctionsBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferJson request, [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
