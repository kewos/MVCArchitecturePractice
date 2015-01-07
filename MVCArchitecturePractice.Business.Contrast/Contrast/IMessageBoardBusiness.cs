using System.Collections.Generic;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Common.DTO;

namespace MVCArchitecturePractice.Business.Contrast
{
    public interface IMessageBoardBusiness : IBusiness
    {
        MessageDTO GetMessage(long id);
        void InsertMessage(MessageDTO message);
        void UpdateMessage(MessageDTO message);
        void DeleteMessage(long id);
        IEnumerable<MessageDTO> GetMessages();
    }
}
