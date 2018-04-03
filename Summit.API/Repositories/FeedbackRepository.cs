using Summit.API.Entities;
using System.Threading.Tasks;
using Summit.API.Data;

namespace Summit.API.Repositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        private readonly SummitContext _summitContext;

        public FeedbackRepository(SummitContext summitContext)
        {
            _summitContext = summitContext;
        }

        public async Task<Feedback> Create(Feedback entity)
        {
            _summitContext.Entry(entity);
            var response = await _summitContext.Set<Feedback>().AddAsync(entity);
            await _summitContext.SaveChangesAsync();
            return response.Entity;
        }

    }
}