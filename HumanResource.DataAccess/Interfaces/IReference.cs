using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IReference
    {

        IEnumerable<Reference> GetAll();

        Reference GetById(int id);

        bool Add(Reference reference);

        bool Update(Reference reference);

        bool Delete(Reference reference);

        bool Delete(int id);


    }
}
