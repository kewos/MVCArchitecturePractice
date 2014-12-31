using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Web.Security;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Business.Contrast;
using MVCArchitecturePractice.Service.Dto;

namespace MVCArchitecturePractice.Service.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository userRepository;

        public AuthenticationService(IRepositoryFactory repositoryFactory, IBusinessFactory businessFactory)
        { 
            userRepository = repositoryFactory.GetRepository<IUserRepository>();
        }

        public bool UserIsValid(UserDto dto)
        {
            bool isValid = userRepository.GetAll().Any(user => user.Name == dto.Name && user.Password == dto.Password);
            if (isValid)
            { 
            }
            return isValid;
        }
    }
}
