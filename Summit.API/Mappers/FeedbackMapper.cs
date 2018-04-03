using System;
using Summit.API.Entities;
using Summit.API.Extensions;
using Summit.API.Models;

namespace Summit.API.Mappers
{
    public class FeedbackMapper : IMapper<FeedbackRequest, Feedback>
    {
        public Feedback Map(FeedbackRequest input)
        {
            var result = new Feedback()
            {
                SessionId = input.SessionId,
                SessionName = input.SessionName,
                Region = input.Region.ToRegionEnum(),
                Review = input.Feedback,
                UserName = input.UserName,
                DateModified = DateTime.Now,
                Rating = input.Rating

            };

            return result;
        }
    }
}
