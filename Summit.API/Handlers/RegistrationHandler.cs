using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Summit.API.Models;
using Summit.API.Repositories;
using Summit.API.Entities;
using Summit.API.Mappers;

namespace Summit.API.Handlers
{
    public class RegistrationHandler : IRegistrationHandler
    {
        private readonly IUserRepository _userRespository;
        private readonly IMapper<RegistrationRequest, User> _mapper;

        public RegistrationHandler(IUserRepository userRepository, IMapper<RegistrationRequest, User> mapper)
        {
            _userRespository = userRepository;
            _mapper = mapper;
        }

        public async Task<ActionResult> Handle(RegistrationRequest request)
        {
            try
            {
                User newUser = _mapper.Map(request);
                await _userRespository.Create(newUser);
                return new OkObjectResult(newUser);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.StackTrace);
            }
            
        }
    }
}
