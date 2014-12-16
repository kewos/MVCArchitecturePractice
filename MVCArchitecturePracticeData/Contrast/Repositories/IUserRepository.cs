using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data.Contrast.Repositories
{
    /// <summary>
    /// 擴充IRepository<User>的方法
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
    }
}
