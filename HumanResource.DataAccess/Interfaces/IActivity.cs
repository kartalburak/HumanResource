using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IActivity
    {

        IEnumerable<Activity> GetAll();

        Activity GetById(int id);

        bool Add(Activity activity);

        bool Update(Activity activity);

        bool Delete(Activity activity);

        bool Delete(int id);


    }
}
