using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Core.Entity;

namespace MVCArchitecturePractice.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository 
    {
    }
}
