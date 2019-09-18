using HumanResource.DataAccess.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResource.DataAccess.Interfaces
{
   public interface IBranch
    {
        IEnumerable<Branch> GetAll();

        Branch GetById(int id);

        bool Add(Branch branch);

        bool Update(Branch branch);

        bool Delete(Branch branch);

        bool Delete(int id);
    }
}
