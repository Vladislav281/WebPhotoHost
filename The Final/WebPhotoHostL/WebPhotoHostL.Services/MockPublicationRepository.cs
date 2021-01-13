using System.Linq;
using WebPhotoHostL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebPhotoHostL.Services
{
    public class MockPublicationRepository : IPublicationRepository //псевдо база данных
    {
        private List<Publication> _publicationList; //все данные заносятся в список

        public MockPublicationRepository()
        {
            _publicationList = new List<Publication>()
            {
                new Publication()
                {
                    Id = 0,
                    Name = "Car",
                   
                    PhotoPath = "adw.png",
                    Department = Dept.Cars
                }
              
            };
        }

        //методы работы с данными 

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

        public IEnumerable<CatCount> PublicationCountByDept(Dept? dept)
        {
            IEnumerable<Publication> query = _publicationList;

            if (dept.HasValue)
                query = query.Where(x => x.Department == dept.Value);

            return query.GroupBy(x => x.Department)
                                .Select(x => new CatCount()
                                {
                                    Category = x.Key.Value,
                                    Count = x.Count()
                                }).ToList();
        }

        public IEnumerable<Publication> GetAllPublications() //метод получения всех публикаций
        {
            return _publicationList; //возвращает все данные из списка
        }

        public Publication GetPublication(int id)
        {
            return _publicationList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Publication> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _publicationList;

            return _publicationList.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()));
        }

        public Publication Update(Publication updatedPublication)
        {
            Publication publication = _publicationList.FirstOrDefault(x => x.Id == updatedPublication.Id);

            if(publication != null)
            {
                publication.Name = updatedPublication.Name;
               
                publication.Department = updatedPublication.Department;
                publication.PhotoPath = updatedPublication.PhotoPath;
            }
            return publication;
        }
    }
}
