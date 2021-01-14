using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public class SQLAdminRepository : IAdminRepository
    {
        private readonly AppDbContext _adminContext;

        public SQLAdminRepository(AppDbContext context)
        {
            _adminContext = context;
        }

  
        public AdminAccount Checkk(string username, string password)
        {
            AdminAccount account = _adminContext.AdminAccount.SingleOrDefault(a => a.Username.Equals(username));
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
