using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Summit.API.Models;

namespace Summit.API.Handlers
{
    public interface IRegistrationHandler
    {
        Task<ActionResult> Handle(RegistrationRequest request);
    }
}
