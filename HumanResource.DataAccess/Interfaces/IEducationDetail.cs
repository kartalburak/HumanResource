using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IEducationDetail
    {

        IEnumerable<EducationDetail> GetAll();

        EducationDetail GetById(int id);

        bool Add(EducationDetail educationDetail);

        bool Update(EducationDetail educationDetail);

        bool Delete(EducationDetail educationDetail);

        bool Delete(int id);

    }
}
