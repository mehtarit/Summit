using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Summit.API.Models;

namespace Summit.API.Handlers
{
    public interface IFeedbackHandler
    {
        Task<ActionResult> Handle(FeedbackRequest request);
    }
}
