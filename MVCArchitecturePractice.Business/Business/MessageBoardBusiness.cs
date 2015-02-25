using System;
using System.Collections.Generic;
using MVCArchitecturePractice.Common.DTO;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Business.Contrast;
using AutoMapper;

namespace MVCArchitecturePractice.Business
{
    public class MessageBoardBusiness : IMessageBoardBusiness
    {
        private IUserRepository userRepository;
        private IMessageRepository messageRepository;

        public MessageBoardBusiness(IRepositoryFactory repositoryFactory)
        {
            userRepository = repositoryFactory.GetRepository<IUserRepository>();
            messageRepository = repositoryFactory.GetRepository<IMessageRepository>();
        }

        public IEnumerable<MessageDTO> GetMessages()
        {
            var result = messageRepository.GetAll();
            return Mapper.Map<IEnumerable<MessageDTO>>(result);
        }

        public MessageDTO GetMessage(long id)
        {
            var result = messageRepository.GetById(id);
            return Mapper.Map<MessageDTO>(result);
        }

        public void InsertMessage(MessageDTO messageDTO)
        {
            messageDTO.AddDate = DateTime.Now;
            var message = Mapper.Map<Message>(messageDTO);
            messageRepository.Insert(message);
        }

        public void UpdateMessage(MessageDTO messageDTO)
        {

        }

        public void DeleteMessage(long id)
        {
            messageRepository.DeleteById(id);
        }
    }
}

