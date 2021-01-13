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

        //внедрение зависимости через конструктор
        public SQLPublicationRepository(AppDbContext context)
        {
            _context = context;
        }

        //Метод добавляет публикацию в базу данных
        public Publication Add(Publication newPublication)
        {
            _context.Publication.Add(newPublication);
            _context.SaveChanges();
            return newPublication;
        }

        //Метод удаляет публикацию из базы данных
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

        //Метод группирует данные по департаментам, считает сколько пользователей в каком департаменте состоит, создает новые экземпляры моделей и заносит их в массив вместе с данными
        public IEnumerable<CatCount> PublicationCountByDept(Dept? dept)
        {
            IEnumerable<Publication> query = _context.Publication;

            if (dept.HasValue)
                query = query.Where(x => x.Department == dept.Value);

            return query.GroupBy(x => x.Department)
                                .Select(x => new CatCount()
                                {
                                    Category = x.Key.Value,
                                    Count = x.Count()
                                }).ToList();
        }

        //Метод получает все публикации
        public IEnumerable<Publication> GetAllPublications()
        {
            return _context.Publication;
        }

        //Метод получает публикацию по id
        public Publication GetPublication(int id)
        {
            return _context.Publication.Find(id);
        }

        //Метод ищет публикацию по содержанию запроса
        public IEnumerable<Publication> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _context.Publication;

            return _context.Publication.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()));
        }

        //Метод применяет редактирование данных в публикации
        public Publication Update(Publication updatedPublication)
        {
            var publication = _context.Publication.Attach(updatedPublication); 
            publication.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedPublication;
        }
    }
}
