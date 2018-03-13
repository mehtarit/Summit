using Summit.API.Entities;
using System.Threading.Tasks;

namespace Summit.API.Repositories
{
    public interface IUserRepository
    {
        Task<User> Create(User Entity);
    }
}
