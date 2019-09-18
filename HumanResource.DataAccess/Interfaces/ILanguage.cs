using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface ILanguage
    {

        IEnumerable<Language> GetAll();

        Language GetById(int id);

        bool Add(Language language);

        bool Update(Language language);

        bool Delete(Language language);

        bool Delete(int id);


    }
}
