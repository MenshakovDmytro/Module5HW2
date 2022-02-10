using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class BoardGameController : ControllerBase
{
    private static readonly BoardGame[] BoardGames = new[]
    {
        new BoardGame()
        {
            Title = "Suburbia",
            Price = 43.16m,
            Currency = Currency.USD,
            Description = "In Suburbia, you and your fellow players are city planners, placing unique building tiles in your small borough, slowing turning it into a mega-metropolis complete with residential, commercial, industrial, and civic areas."
        },
        new BoardGame()
        {
            Title = "Arkham Horror",
            Price = 77.77m,
            Currency = Currency.USD,
            Description = "It is the roaring 20's, and while there's electricity in the air, unnatural storms are brewing as well. Strange things are happening in the small Massachusetts town of Arkham"
        },
        new BoardGame()
        {
            Title = "Mage Knight Board Game",
            Price = 42.99m,
            Currency = Currency.USD,
            Description = "The Mage Knight Board Game throws you and up to three other Mage Knights into the sprawling and ever changing world of the Atlantean Empire, a land that is but a distant memory since your transformation into a mysterious Mage Knight. "
        }
    };

    private readonly ILogger<BoardGameController> _logger;

    public BoardGameController(ILogger<BoardGameController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<BoardGame> Get()
    {
        return BoardGames;
    }
}