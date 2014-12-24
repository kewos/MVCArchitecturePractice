using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Service.Contrast;

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
            return messageRepository.GetAll().AsEnumerable();
        }

        public Message GetMessage(long id)
        {
            return messageRepository.GetById(id);
        }

        public void InsertMessage(Message message)
        {
            message.AddDate = DateTime.Now;
            messageRepository.Insert(message);
        }

        public void UpdateMessage(Message message)
        {
            var target = GetMessage(message.ID);
            if (target != null as Message)
            {
                target.Comment = message.Comment;
                target.UserId = message.UserId;
                target.ModifyDate = DateTime.Now;
                messageRepository.Update(target);
            }
        }

        public void DeleteMessage(long id)
        {
            messageRepository.DeleteById(id);
        }
    }
}

