using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast;

namespace MVCArchitecturePractice.Service
{
    public class MessageBoardService : IMessageBoardService
    {
        private IRepository<User> userRepository;
        private IRepository<Message> messageRepository;

        public MessageBoardService(IRepository<User> userRepository, IRepository<Message> messageRepository)
        {
            this.userRepository = userRepository;
            this.messageRepository = messageRepository;
        }

        public IQueryable<Message> GetMessages()
        {
            return messageRepository.Table;
        }

        public Message GetMessage(long id)
        {
            return messageRepository.GetById(id);
        }

        public void InsertMessage(Message message)
        {
            messageRepository.Insert(message);
        }

        public void UpdateMessage(Message message)
        {
            messageRepository.Update(message);
        }

        public void DeleteMessage(Message message)
        {
            messageRepository.Delete(message);
        }
    }
}

