using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Service.Contrast
{
    public interface IMessageBoardService
    {
        Message GetMessage(long id);
        void InsertMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(long id);
        IEnumerable<Message> GetMessages();
    }
}
