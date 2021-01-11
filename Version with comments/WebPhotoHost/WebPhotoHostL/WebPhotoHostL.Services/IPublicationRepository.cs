using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public interface IPublicationRepository //интерфейс, содержит методы для доступа к данным
    {
        IEnumerable<Publication> Search(string searchTerm); //поиск (получает строку)
        IEnumerable<Publication> GetAllPublications(); //получение всех публикаций
        Publication GetPublication(int id);  //получить определнную публикацию (получает id)
        Publication Update(Publication updatedPublication); //обновление публикации 
        Publication Add(Publication newPublication); //добавление публикации
        Publication Delete(int id); //удаление публикации 
        IEnumerable<DeptHeadCount> PublicationCountByDept(Dept? dept); 



    }
}
