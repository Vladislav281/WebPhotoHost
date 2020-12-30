using System.Linq;
using WebPhotoHostL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebPhotoHostL.Services
{
    public class MockPublicationRepository : IPublicationRepository
    {
        private List<Publication> _publicationList;

        public MockPublicationRepository()
        {
            _publicationList = new List<Publication>()
            {
                new Publication()
                {
                    Id = 0,
                    Name = "Mary",
                    Email = "mary@example.com",
                    PhotoPath = "avatar2.png",
                    Department = Dept.HR
                },
                new Publication()
                {
                    Id = 1, Name = "Mark", Email = "mark@example.com", PhotoPath = "avatar.png", Department = Dept.IT
                },
                new Publication()
                {
                    Id = 2,
                    Name = "Kolyan",
                    Email = "demonick@example.com",
                    PhotoPath = "avatar4.png",
                    Department = Dept.IT
                },
                new Publication()
                {
                    Id = 3,
                    Name = "Shawn",
                    Email = "shawn@example.com",
                    PhotoPath = "avatar5.png",
                    Department = Dept.Payroll
                },
                new Publication()
                {
                    Id = 4,
                    Name = "Jenifer",
                    Email = "jenifer@example.com",
                    PhotoPath = "avatar3.png",
                    Department = Dept.HR
                },
                new Publication()
                {
                    Id = 5,
                    Name = "Sten",
                    Email = "sten@example.com",
                    Department = Dept.Payroll
                }
            };
        }

        public Publication Add(Publication newPublication)
        {
            newPublication.Id = _publicationList.Max(x => x.Id) + 1;
            _publicationList.Add(newPublication);
            return newPublication;
        }

        public Publication Delete(int id)
        {
            Publication publicationToDelete = _publicationList.FirstOrDefault(x => x.Id == id);
            if (publicationToDelete != null)
                _publicationList.Remove(publicationToDelete);
            
            return publicationToDelete;
        }

        public IEnumerable<DeptHeadCount> PublicationCountByDept(Dept? dept)
        {
            IEnumerable<Publication> query = _publicationList;

            if (dept.HasValue)
                query = query.Where(x => x.Department == dept.Value);

            return query.GroupBy(x => x.Department)
                                .Select(x => new DeptHeadCount()
                                {
                                    Deptepartment = x.Key.Value,
                                    Count = x.Count()
                                }).ToList();
        }

        public IEnumerable<Publication> GetAllPublications()
        {
            return _publicationList;
        }

        public Publication GetPublication(int id)
        {
            return _publicationList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Publication> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _publicationList;

            return _publicationList.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.Contains(searchTerm.ToLower()));
        }

        public Publication Update(Publication updatedPublication)
        {
            Publication publication = _publicationList.FirstOrDefault(x => x.Id == updatedPublication.Id);

            if(publication != null)
            {
                publication.Name = updatedPublication.Name;
                publication.Email = updatedPublication.Email;
                publication.Department = updatedPublication.Department;
                publication.PhotoPath = updatedPublication.PhotoPath;
            }
            return publication;
        }
    }
}
