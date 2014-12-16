using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
    }
}
