using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Core.Entity;

namespace MVCArchitecturePractice.Data.Contrast.Repository
{
    /// <summary>
    /// 擴充IRepository<User>的方法
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
    }
}
