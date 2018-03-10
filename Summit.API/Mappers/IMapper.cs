namespace Summit.API.Mappers
{
    public interface IMapper<in T1, out T2>
    {
        T2 Map(T1 input);
    }
}
