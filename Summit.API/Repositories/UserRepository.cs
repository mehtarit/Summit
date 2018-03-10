using Summit.API.Entities;
using System.Threading.Tasks;
using Summit.API.Data;

namespace Summit.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SummitContext _summitContext;

        public UserRepository(SummitContext summitContext)
        {
            _summitContext = summitContext;
        }

        public Task Create(User Entity)
        {
            throw new System.NotImplementedException();
        }

    }
}
