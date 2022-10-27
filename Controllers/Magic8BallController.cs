// Amardeep Mann
// 10-27-22
// Magic 8 Ball - Endpoint
// Create a Magic 8 Ball WebAPI project that takes in a string variable via the URL as a question and presents the user with a randomly generated answer
// Peer reviewed by: Jacob Dekok - The program runs perfectly and I found no errors. I like how he added two routes the program could take, one if you don't want to type out the question and the other will output your question along with an answer from the magic 8. The code is very organized and I see he used some of the things we learned in todays lecture(10/27/2022) like putting the route with the [HttpGet("...")]

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