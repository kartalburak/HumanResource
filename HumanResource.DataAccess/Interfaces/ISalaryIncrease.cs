using HumanResource.DataAccess.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResource.DataAccess.Interfaces
{
   public interface  ISalaryIncrease
    {
        IEnumerable<SalaryIncrease> GetAll();

        SalaryIncrease GetById(int id);

        bool Add(SalaryIncrease salaryIncrease);

        bool Update(SalaryIncrease salaryIncrease);

        bool Delete(SalaryIncrease salaryIncrease);

        bool Delete(int id);
    }
}
