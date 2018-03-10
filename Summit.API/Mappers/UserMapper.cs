using Summit.API.Entities;
using Summit.API.Models;
using System;
using Summit.API.Extensions;

namespace Summit.API.Mappers
{
    public class UserMapper : IMapper<RegistrationRequest, User>
    {
        public User Map(RegistrationRequest request)
        {
            var result = new User
            {
                Username = request.Username,
                Region = request.Region.ToRegionEnum(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                PreferedName = request.PreferedName,
                IsCioPeople = request.IsCioPeople,
                IsITDP = request.IsITDP,
                IsITLP = request.IsITLP,
                IsLeader = request.IsLeader,
                IsGraduate = request.IsGraduate,
                TShirtSize = request.TShirtSize.ToTshirtSizeEnum(),
                City = request.City.ToCityEnum(),
                Country = request.Country.ToCountryEnum(),
                Email = request.Email,
                Phone = request.Phone,
                DateTime = DateTime.Now
            };

            return result;
        }
    }
}
