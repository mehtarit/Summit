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
            var result = new User();

            result.Username = request.Username;
            result.Region = request.Region.ToRegionEnum();
            result.FirstName = request.FirstName;
            result.LastName = request.LastName;
            result.PreferedName = request.PreferedName;
            result.IsCioPeople = request.IsCioPeople;
            result.IsITDP = request.IsITDP;
            result.IsITLP = request.IsITLP;
            result.IsLeader = request.IsLeader;
            result.IsGraduate = request.IsGraduate;
            result.TShirtSize = request.TShirtSize.ToTshirtSizeEnum();
            result.City = request.City.ToCityEnum();
            result.Country = request.Country.ToCountryEnum();
            result.Email = request.Email;
            result.Phone = request.Phone;
            result.DateTime = DateTime.Now;

            return result;
        }
    }
}
