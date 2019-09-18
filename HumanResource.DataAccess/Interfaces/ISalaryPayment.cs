using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface ISalaryPayment
    {
        IEnumerable<SalaryPayment> GetAll();

        SalaryPayment GetById(int id);

        bool Add(SalaryPayment salaryPayment);

        bool Update(SalaryPayment salaryPayment);

        bool Delete(SalaryPayment salaryPayment);

        bool Delete(int id);
    }
}
