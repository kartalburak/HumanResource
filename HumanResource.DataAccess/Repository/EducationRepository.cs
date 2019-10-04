using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Repository
{
    public class EducationRepository : IEducation
    {
        private readonly HumanResourceContext _humanResourceContext;
        public EducationRepository(HumanResourceContext humanResourceContext)
        {
            _humanResourceContext = humanResourceContext;
        }
        public bool Add(Education education)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Education education)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Education> GetAll()
        {
            return _humanResourceContext.Educations;
        }

        public Education GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Education education)
        {
            throw new System.NotImplementedException();
        }
    }
}
