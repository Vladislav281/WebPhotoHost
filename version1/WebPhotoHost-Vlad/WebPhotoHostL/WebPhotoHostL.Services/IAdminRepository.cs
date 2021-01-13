using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public interface IAdminRepository
    {
        AdminAccount Checkk(string username, string password);
    }
}
