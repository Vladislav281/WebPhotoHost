using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext _userContext;

        public SQLUserRepository(AppDbContext context)
        {
            _userContext = context;
        }

        public User Check(string username, string password)
        {
            User account = _userContext.User.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
                    
                
            }
            return null;
        }
    }
}
