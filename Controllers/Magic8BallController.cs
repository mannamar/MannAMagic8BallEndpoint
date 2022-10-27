using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MannAMagic8BallEndpoint.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class Magic8BallController : ControllerBase
  {
    [HttpGet]
    public string Magic8BallDefault()
    {
      string[] eightBallArray = new string[] { "Indubitably my dear Watson", "Maybe when hell freezes over", "My sources say no, but they also said Hillary would win so...", "Uhhh.. Trust me you don't want to know", "DON'T BET THE FARM ON IT!", "Pop champagne, do the Dougie, eat some cake. It's a sure thing", "Yes. YES. A thousand times YES!", "Bruh. You know. You've always known.", "Search your feelings, you know it to be true", "I looked forward in time and saw 14,000,605 possible futures. It's true in exactly one of them", "*Astronaut meme intensifies* Always" };
      Random randNum = new Random();
      int randIndex = randNum.Next(1, 4);
      return $"Magic 8-Ball says:\n{eightBallArray[randIndex]}";
    }

    [HttpGet("{question}")]

    public string Magic8Ball(string question)
    {
      string[] eightBallArray = new string[] { "Indubitably my dear Watson", "Maybe when hell freezes over", "My sources say no, but they also said Hillary would win so...", "Uhhh.. Trust me you don't want to know", "DON'T BET THE FARM ON IT!", "Pop champagne, do the Dougie, eat some cake. It's a sure thing", "Yes. YES. A thousand times YES!", "Bruh. You know. You've always known.", "Search your feelings, you know it to be true", "I looked forward in time and saw 14,000,605 possible futures. It's true in exactly one of them", "*Astronaut meme intensifies* Always" };
      Random randNum = new Random();
      int randIndex = randNum.Next(1, 4);
      return $"Your question:\n{question}?\nMagic 8-Ball says:\n{eightBallArray[randIndex]}";
    }

  }
}