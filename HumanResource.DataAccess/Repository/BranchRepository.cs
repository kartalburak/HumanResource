using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Repository
{
    public class BranchRepository : IBranch
    {
        private readonly HumanResourceContext _humanResourceContext;

        public BranchRepository(HumanResourceContext humanResourceContext)
        {
            _humanResourceContext = humanResourceContext;
        }
        public bool Add(Branch branch)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Branch branch)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Branch> GetAll()
        {
            return _humanResourceContext.Branches;
        }

        public Branch GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Branch branch)
        {
            throw new System.NotImplementedException();
        }
    }
}
