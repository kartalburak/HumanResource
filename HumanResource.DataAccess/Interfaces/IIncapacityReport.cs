using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IIncapacityReport
    {
        IEnumerable<IncapacityReport> GetAll();

        IncapacityReport GetById(int id);

        bool Add(IncapacityReport incapacityReport);

        bool Update(IncapacityReport incapacityReport);

        bool Delete(IncapacityReport incapacityReport);

        bool Delete(int id);


    }
}
