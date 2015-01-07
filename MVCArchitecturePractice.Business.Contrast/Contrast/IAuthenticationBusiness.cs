using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Common.DTO;

namespace MVCArchitecturePractice.Business.Contrast
{
    public interface IAuthenticationBusiness : IBusiness
    {
        bool UserIsValid(UserDTO dto);
    }
}