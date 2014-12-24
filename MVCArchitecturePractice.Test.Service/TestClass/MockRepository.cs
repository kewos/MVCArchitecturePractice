using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Data.Contrast.Repositories;

namespace MVCArchitecturePractice.Test.Service.TestClass
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> context;

        public MockUserRepository(List<User> context)
        {
            this.context = context;
        }

        public void Delete(User entity)
        {
            context.Remove(entity);
        }

        public IEnumerable<User> GetAll()
        {
            return context;
        }

        public User GetById(long id)
        {
            return context.Where(n => n.ID == id).FirstOrDefault();
        }

        public void Insert(User entity)
        {
            context.Add(entity);
        }

        public void Update(User entity)
        {
            foreach (var user in context.Where(n => n.ID == entity.ID))
            {
                user.Email = entity.Email;
                user.Email = entity.Email;
                user.Email = entity.Email;
                user.Email = entity.Email;
            }
        }
    }

    public class MockMessageRepositoryRepository : IMessageRepository
    {
        private List<Message> context;

        public MockMessageRepositoryRepository(List<Message> context)
        {
            this.context = context;
        }

        public void Delete(Message entity)
        {
            context.RemoveAll(n => n.ID == entity.ID);
        }

        public IEnumerable<Message> GetAll()
        {
            return context;
        }

        public Message GetById(long id)
        {
            return context.Where(n => n.ID == id).FirstOrDefault();
        }

        public void Insert(Message entity)
        {
            context.Add(entity);
        }

        public void Update(Message entity)
        {
            foreach (var message in context.Where(n => n.ID == entity.ID))
            {
                message.Comment = entity.Comment;
            }
        }
    }
}
