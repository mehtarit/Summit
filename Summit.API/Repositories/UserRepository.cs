﻿using Summit.API.Entities;
using System.Threading.Tasks;
using Summit.API.Data;

namespace Summit.API.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly SummitContext _summitContext;

        public UserRepository(SummitContext summitContext)
        {
            _summitContext = summitContext;
        }

        public async Task<User> Create(User entity)
        {
            _summitContext.Entry(entity);
            var response = await _summitContext.Set<User>().AddAsync(entity);
            await _summitContext.SaveChangesAsync();
            return response.Entity;
        }

    }
}
