using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Data.Contrast;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Data.Contrast.Repository;

namespace MVCArchitecturePractice.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
    }
}
