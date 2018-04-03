using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Summit.API.Entities;
using Summit.API.Mappers;
using Summit.API.Models;
using Summit.API.Repositories;

namespace Summit.API.Handlers
{
    public class FeedbackHandler : IFeedbackHandler
    {
        private readonly IMapper<FeedbackRequest, Feedback> _mapper;
        private readonly IRepository<Feedback> _feedbackRepository;
        public FeedbackHandler(IMapper<FeedbackRequest, Feedback> mapper, IRepository<Feedback> feedbackRepository)
        {
            _mapper = mapper;
            _feedbackRepository = feedbackRepository;
        }
        public async Task<ActionResult> Handle(FeedbackRequest request)
        {
            try
            {
                Feedback newFeedback = _mapper.Map(request);
                await _feedbackRepository.Create(newFeedback);
                return new OkObjectResult(newFeedback);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.StackTrace);
            }
        }
    }
}
