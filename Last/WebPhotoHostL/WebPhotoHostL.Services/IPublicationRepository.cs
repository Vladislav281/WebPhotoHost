using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public interface IPublicationRepository
    {
        IEnumerable<Publication> Search(string searchTerm);
        IEnumerable<Publication> GetAllPublications();
        Publication GetPublication(int id);
        Publication Update(Publication updatedPublication);
        Publication Add(Publication newPublication);
        Publication Delete(int id);
        IEnumerable<DeptHeadCount> PublicationCountByDept(Dept? dept);



    }
}
