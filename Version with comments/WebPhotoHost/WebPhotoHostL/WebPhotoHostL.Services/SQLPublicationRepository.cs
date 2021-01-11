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
            _context.Publication.Add(newPublication);
            _context.SaveChanges();
            return newPublication;
        }

        public Publication Delete(int id)
        {
            var publicationToDelete = _context.Publication.Find(id);
            if(publicationToDelete != null)
            {
                _context.Publication.Remove(publicationToDelete);
                _context.SaveChanges();
            }
            return publicationToDelete;
        }

        public IEnumerable<DeptHeadCount> PublicationCountByDept(Dept? dept)
        {
            IEnumerable<Publication> query = _context.Publication;

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
            return _context.Publication;
        }

        public Publication GetPublication(int id)
        {
            return _context.Publication.Find(id);
        }

        public IEnumerable<Publication> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _context.Publication;

            return _context.Publication.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.Contains(searchTerm.ToLower()));
        }

        public Publication Update(Publication updatedPublication)
        {
            var publication = _context.Publication.Attach(updatedPublication); 
            publication.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedPublication;
        }
    }
}
