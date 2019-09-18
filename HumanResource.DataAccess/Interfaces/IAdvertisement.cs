using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IAdvertisement
    {

        IEnumerable<Advertisement> GetAll();

        Advertisement GetById(int id);

        bool Add(Advertisement advertisement);

        bool Update(Advertisement advertisement);

        bool Delete(Advertisement advertisement);

        bool Delete(int id);

    }
}
