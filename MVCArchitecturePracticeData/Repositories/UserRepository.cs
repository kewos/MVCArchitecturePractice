using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}
