using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public interface IUserRepository
    {
        User Check(string username, string password);
    }
}
