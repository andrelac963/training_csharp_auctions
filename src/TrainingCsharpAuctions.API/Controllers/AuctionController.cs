﻿using Microsoft.AspNetCore.Mvc;
using TrainingCsharpAuctions.API.Entities;
using TrainingCsharpAuctions.API.UseCases.Auctions.GetCurrent;

namespace TrainingCsharpAuctions.API.Controllers;

public class AuctionController : TrainingCsharpAuctionsBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if (result is null)
        {
            return NoContent();
        }

        return Ok(result);
    }
}
