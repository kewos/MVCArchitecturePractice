using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Common.DTO;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Data.Contrast.Repository;
using MVCArchitecturePractice.Business.Contrast;

namespace MVCArchitecturePractice.Business
{
    public class AuthenticationBusiness : IAuthenticationBusiness
    {
        private IUserRepository userRepository;

        public AuthenticationBusiness(IRepositoryFactory repositoryFactory)
        { 
            userRepository = repositoryFactory.GetRepository<IUserRepository>();
        }

        public bool UserIsValid(UserDTO dto)
        {
            bool isValid = userRepository.GetAll().Any(user => user.Name == dto.Name && user.Password == dto.Password);
            if (isValid)
            { 
            }
            return isValid;
        }
    }
}
