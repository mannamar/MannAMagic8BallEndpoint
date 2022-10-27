// Amardeep Mann
// 10-27-22
// Magic 8 Ball - Endpoint
// Create a Magic * Ball WebAPI project that takes in a string variable via the URL as a question and presents the user wit ha randomly generated answer
// Peer reviewed by

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
      int randIndex = randNum.Next(eightBallArray.Length);
      return $"Magic 8-Ball says:\n{eightBallArray[randIndex]}";
    }

    [HttpGet("{question}")]

    public string Magic8Ball(string question)
    {
      string[] eightBallArray = new string[] { "Indubitably my dear Watson", "Maybe when hell freezes over", "My sources say no, but they also said Hillary would win so...", "Uhhh.. Trust me you don't want to know", "DON'T BET THE FARM ON IT!", "Pop champagne, do the Dougie, eat some cake. It's a sure thing", "Yes. YES. A thousand times YES!", "Bruh. You know. You've always known.", "Search your feelings, you know it to be true", "I looked forward in time and saw 14,000,605 possible futures. It's true in exactly one of them", "*Astronaut meme intensifies* Always" };
      Random randNum = new Random();
      int randIndex = randNum.Next(eightBallArray.Length);
      return $"Your question:\n{question}?\n\nMagic 8-Ball says:\n{eightBallArray[randIndex]}";
    }

  }
}