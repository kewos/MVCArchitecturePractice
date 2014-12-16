using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;

namespace MVCArchitecturePractice.Service
{
    public class MessageBoardService : IMessageBoardService
    {
        private IUserRepository userRepository;
        private IMessageRepository messageRepository;

        public MessageBoardService(IUserRepository userRepository, IMessageRepository messageRepository)
        {
            this.userRepository = userRepository;
            this.messageRepository = messageRepository;
        }

        public IEnumerable<Message> GetMessages()
        {
            return messageRepository.GetAll();
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

