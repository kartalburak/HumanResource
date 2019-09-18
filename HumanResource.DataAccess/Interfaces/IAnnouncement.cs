using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IAnnouncement
    {

        IEnumerable<Announcement> GetAll();

        Announcement GetById(int id);

        bool Add(Announcement announcement);

        bool Update(Announcement announcement);

        bool Delete(Announcement announcement);

        bool Delete(int id);

    }
}
