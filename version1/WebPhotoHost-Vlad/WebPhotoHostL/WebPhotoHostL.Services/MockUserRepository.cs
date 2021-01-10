using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _UserList;

        public MockUserRepository()
        {
            _UserList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Username = "Mary",
                    Password = "def",

                }

            };
        }

        public User Check(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
