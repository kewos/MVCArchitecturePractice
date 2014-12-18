using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Data.Contrast;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;

namespace MVCArchitecturePractice.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
    }
}
