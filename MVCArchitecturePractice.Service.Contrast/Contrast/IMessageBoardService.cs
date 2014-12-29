using System;
using System.Collections.Generic;
using System.Linq;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Service.Dto;

namespace MVCArchitecturePractice.Service.Contrast
{
    public interface IMessageBoardService : IService
    {
        MessageDto GetMessage(long id);
        void InsertMessage(MessageDto message);
        void UpdateMessage(MessageDto message);
        void DeleteMessage(long id);
        IEnumerable<MessageDto> GetMessages();
    }
}
