using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Service.Dto;

public interface IAuthenticationService : IService
{
    bool UserIsValid(UserDto dto);
}