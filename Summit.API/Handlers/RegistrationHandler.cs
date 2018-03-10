using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Summit.API.Models;

namespace Summit.API.Handlers
{
    public class RegistrationHandler : IRegistrationHandler
    {
        public Task<ActionResult> Handle(RegistrationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
