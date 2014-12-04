using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Data;
using MVCArchitecturePractice.Data;

namespace MVCArchitecturePractice.Service
{
    public class MessageBoard : MVCArchitecturePractice.Service.IMessageBoard
    {
        private IRepository<User> userRepository;
        private IRepository<Message> messageRepository;

        public MessageBoard(IRepository<User> userRepository, IRepository<Message> messageRepository)
        {
            this.userRepository = userRepository;
            this.messageRepository = messageRepository;
        }

        public IQueryable<Message> GetMessages()
        {
            return messageRepository.Table;
        }

        public Message GetMessages(long id)
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

