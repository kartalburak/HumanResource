using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Repository
{
    public class MissionRepository : IMission
    {
        private readonly HumanResourceContext _humanResourceContext;

        public MissionRepository(HumanResourceContext humanResourceContext)
        {
            _humanResourceContext = humanResourceContext;
        }
        public bool Add(Mission mission)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Mission mission)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mission> GetAll()
        {
            return _humanResourceContext.Missions;
        }

        public Mission GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Mission mission)
        {
            throw new NotImplementedException();
        }
    }
}
