using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{ //методы реальной бд
    public class SQLPublicationRepository : IPublicationRepository
    {
        private readonly AppDbContext _context;

        public SQLPublicationRepository(AppDbContext context)
        {
            _context = context;
        }

        public Publication Add(Publication newPublication)
        {
            _context.Publications.Add(newPublication);
            _context.SaveChanges();
            return newPublication;
        }

        public Publication Delete(int id)
        {
            var publicationToDelete = _context.Publications.Find(id);
            if(publicationToDelete != null)
            {
                _context.Publications.Remove(publicationToDelete);
                _context.SaveChanges();
            }
            return publicationToDelete;
        }

        public IEnumerable<DeptHeadCount> PublicationCountByDept(Dept? dept)
        {
            IEnumerable<Publication> query = _context.Publications;

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
            return _context.Publications;
        }

        public Publication GetPublication(int id)
        {
            return _context.Publications.Find(id);
        }

        public IEnumerable<Publication> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _context.Publications;

            return _context.Publications.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.Contains(searchTerm.ToLower()));
        }

        public Publication Update(Publication updatedPublication)
        {
            var publication = _context.Publications.Attach(updatedPublication);
            publication.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedPublication;
        }
    }
}
