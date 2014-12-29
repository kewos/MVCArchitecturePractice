using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Business.Contrast;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Service.Dto;
using AutoMapper;

namespace MVCArchitecturePractice.Service
{
    public class MessageBoardService : IMessageBoardService
    {
        private IUserRepository userRepository;
        private IMessageRepository messageRepository;
        private IMessageBoardBusiness messageBoardBusiness;

        public MessageBoardService(IRepositoryFactory repositoryFactory, IBusinessFactory businessFactory)
        {
            userRepository = repositoryFactory.GetRepository<IUserRepository>();
            messageRepository = repositoryFactory.GetRepository<IMessageRepository>();
            messageBoardBusiness = businessFactory.GetBusiness<IMessageBoardBusiness>();
        }

        public IEnumerable<MessageDto> GetMessages()
        {
            var result = messageRepository.GetAll();
            return Mapper.Map<IEnumerable<MessageDto>>(result);
        }

        public MessageDto GetMessage(long id)
        {
            var result = messageRepository.GetById(id);
            return Mapper.Map<MessageDto>(result);
        }

        public void InsertMessage(MessageDto messageDto)
        {
            messageDto.AddDate = DateTime.Now;
            var message = Mapper.Map<Message>(messageDto);
            messageRepository.Insert(message);
        }

        public void UpdateMessage(MessageDto messageDto)
        {
            //messageDto.ModifyDate = DateTime.Now;
            //var destination = messageRepository.GetById(messageDto.ID);
            //var RESULT = Mapper.Map(messageDto, destination);
            //messageRepository.Update(Mapper.Map(messageDto, destination));
        }

        public void DeleteMessage(long id)
        {
            messageRepository.DeleteById(id);
        }
    }
}

