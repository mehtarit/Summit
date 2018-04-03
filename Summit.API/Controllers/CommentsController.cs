using Microsoft.AspNetCore.Mvc;
using Summit.API.Handlers;
using Summit.API.Models;
using System.Threading.Tasks;

namespace Summit.API.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        private readonly IFeedbackHandler _feedbackHandler;

        public SessionsController(IFeedbackHandler feedbackHandler)
        {
            _feedbackHandler = feedbackHandler;
        }

        // POST api/users
        [HttpPost]
        public async Task<IActionResult> Feedback([FromBody] FeedbackRequest feedbackCreateRequest)
        {
            return await _feedbackHandler.Handle(feedbackCreateRequest);
        }

    }
}
