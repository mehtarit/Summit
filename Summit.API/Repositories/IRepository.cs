using System.Threading.Tasks;

namespace Summit.API.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Create(T Entity);
    }
}
