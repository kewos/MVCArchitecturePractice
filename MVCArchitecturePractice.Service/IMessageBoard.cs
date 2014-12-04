using System;
using MVCArchitecturePractice.Core.Data;

namespace MVCArchitecturePractice.Service
{
    public interface IMessageBoard
    {
        Message GetMessages(long id);
        void InsertMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(Message message);
        System.Linq.IQueryable<Message> GetMessages();
    }
}
