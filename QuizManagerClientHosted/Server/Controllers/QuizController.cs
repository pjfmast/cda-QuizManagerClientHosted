using Microsoft.AspNetCore.Mvc;
using QuizManagerClientHosted.Shared;
using Microsoft.AspNetCore.Authorization;  // added for auth0

namespace QuizManagerClientHosted.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class QuizController : ControllerBase
    {
        private static readonly List<QuizItem> Quiz = new List<QuizItem> {
    new QuizItem
      {
        Question = "Which of the following is the name of a Leonardo da Vinci's masterpiece?",
        Choices = new List<string> {"Sunflowers", "Mona Lisa", "The Kiss"},
        AnswerIndex = 1,
        Score = 3
      },
    new QuizItem
      {
        Question = "Which of the following novels was written by Miguel de Cervantes?",
        Choices = new List<string> {"The Ingenious Gentleman Don Quixote of La Mancia", "The Life of Gargantua and of Pantagruel", "One Hundred Years of Solitude"},
        AnswerIndex = 0,
        Score = 5
      },
     new QuizItem
      {
        Question = "What is PKCE?",
        Choices = new List<string> {"Pro Kotlin Code Expert", "Possible Key C# Exception", "Proof Key for Code Exchange"},
        AnswerIndex = 2,
        Score = 5
      }
    };

        [HttpGet]
        public List<QuizItem> Get()
        {
            return Quiz;
        }
    }
}
