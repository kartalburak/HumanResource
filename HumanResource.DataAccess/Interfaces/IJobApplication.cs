using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IJobApplication
    {

        IEnumerable<JobApplication> GetAll();

        JobApplication GetById(int id);

        bool Add(JobApplication jobApplication);

        bool Update(JobApplication jobApplication);

        bool Delete(JobApplication jobApplication);

        bool Delete(int id);


    }
}
