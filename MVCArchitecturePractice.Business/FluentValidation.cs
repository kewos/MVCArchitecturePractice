using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MVCArchitecturePractice.Common.DTO;
using Microsoft.Practices.Unity;

namespace MVCArchitecturePractice.Business
{
    public interface IValidationFactory
    {
        TValidation GetValidation<TValidation>() 
            where TValidation : IValidator;
    }

    public class ValidationFactory : IValidationFactory
    {
        IUnityContainer container;
        public ValidationFactory(IUnityContainer container)
        {
            this.container = container;
        }

        public TValidation GetValidation<TValidation>()
        {
            return container.Resolve<TValidation>();
        }
    }

    public class MessageDTOValidation : AbstractValidator<MessageDTO>
    {
        public MessageDTOValidation()
        {
            RuleFor(message => message.Comment.Length).LessThanOrEqualTo(100);
        }
    }

    public class UserDTOValidation : AbstractValidator<UserDTO>
    {
        public UserDTOValidation()
        {
        }
    }
}
