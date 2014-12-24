using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCArchitecturePractice.Data.Contrast.Repositories;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Service;
using System.Diagnostics;
using System.Linq;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Test.Service.TestClass;
using Moq;

namespace MVCArchitecturePractice.Test.Service
{
    [TestClass]
    public class MessageBoardServiceTest
    {
        private IMessageRepository MessageRepository
        {
            get
            {
                var mockMessageRepository = new Mock<IMessageRepository>();
                mockMessageRepository
                    .Setup(repository => repository.GetAll())
                    .Returns(new List<Message> { new Message { ID = 1 } });
                mockMessageRepository.Setup(repository => repository.Update(new Message { ID = 1 }));
                mockMessageRepository.Setup(repository => repository.Insert(new Message { ID = 1 }));
                mockMessageRepository.Setup(repository => repository.Delete(new Message { ID = 1 }));
                mockMessageRepository.Setup(repository => repository.GetById((long)1)).Returns(new Message { ID = 1 });

                return mockMessageRepository.Object;
            }
        }

        private IUserRepository UserRepository
        {
            get
            {
                var mockUserRepository = new Mock<IUserRepository>();
                mockUserRepository
                    .Setup(repository => repository.GetAll())
                    .Returns(new List<User> { new User { ID = 1 } });
                mockUserRepository.Setup(repository => repository.Update(new User { ID = 1 }));
                mockUserRepository.Setup(repository => repository.Insert(new User { ID = 1 }));
                mockUserRepository.Setup(repository => repository.Delete(new User { ID = 1 }));
                mockUserRepository.Setup(repository => repository.GetById((long)1)).Returns(new User { ID = 1 });

                return mockUserRepository.Object;
            }
        } 

        [TestMethod]
        public void GetMessage_InsertOne_ReturnIDOne()
        {
            //Arrange
            var service = new MessageBoardService(UserRepository, MessageRepository);

            //Act
            var actual = service.GetMessage(1);

            //Assert
            var expect = 1;
            Assert.AreEqual(expect, actual.ID);
        }

        [TestMethod]
        public void GetMessages_InsertVoid_ReturnMessageList()
        {
            //Arrange
            var service = new MessageBoardService(UserRepository, MessageRepository);

            //Act
            var actual = service.GetMessages();

            //Assert
            var expect = 1;
            Assert.AreEqual(expect, actual.Count());
        }
    }
}
