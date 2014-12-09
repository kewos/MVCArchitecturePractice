using System;
using MVCArchitecturePractice.Core.Entities;

namespace MVCArchitecturePractice.Service
{
    public interface IMessageBoardService
    {
        Message GetMessage(long id);
        void InsertMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(Message message);
        System.Linq.IQueryable<Message> GetMessages();
    }
}
