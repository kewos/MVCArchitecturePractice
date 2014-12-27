using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Service.Dto;
using AutoMapper;

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

        public IEnumerable<MessageDto> GetMessages()
        {
            var result = messageRepository.GetAll();
            return Mapper.Map<IEnumerable<MessageDto>>(result);
        }

        public MessageDto GetMessage(long id)
        {
            return Mapper.Map<MessageDto>(messageRepository.GetById(id));
        }

        public void InsertMessage(MessageDto messageDto)
        {
            messageDto.AddDate = DateTime.Now;
            messageRepository.Insert(Mapper.Map<Message>(messageDto));
        }

        public void UpdateMessage(MessageDto messageDto)
        {
            messageDto.ModifyDate = DateTime.Now;
            var destination = messageRepository.GetById(messageDto.ID);
            var RESULT = Mapper.Map(messageDto, destination);
            messageRepository.Update(Mapper.Map(messageDto, destination));
        }

        public void DeleteMessage(long id)
        {
            messageRepository.DeleteById(id);
        }
    }
}

