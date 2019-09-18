using HumanResource.DataAccess.Core;
using Microsoft.EntityFrameworkCore;

namespace HumanResource.DataAccess
{
    public class HumanResourceContext : DbContext
    {
        public HumanResourceContext(DbContextOptions options) : base(options)
        {

        }


        #region DbSets

        public virtual DbSet<Activity> Activities { get; set; }

        public virtual DbSet<Advertisement> Advertisements { get; set; }

        public virtual DbSet<Announcement> Announcements { get; set; }

        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Education> Educations { get; set; }

        public virtual DbSet<EducationDetail> EducationDetails { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<EmployeeIO> EmployeeIos { get; set; }

        public virtual DbSet<EmployeeRating> EmployeeRatings { get; set; }

        public virtual DbSet<IncapacityReport> IncapacityReports { get; set; }

        public virtual DbSet<JobApplication> JobApplications { get; set; }

        public virtual DbSet<Language> Languages { get; set; }

        public virtual DbSet<Log> Logs { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<Mission> Missions { get; set; }

        public virtual DbSet<Plan> Plans { get; set; }

        public virtual DbSet<Permit> Permits { get; set; }

        public virtual DbSet<Reference> References { get; set; }

        public virtual DbSet<SalaryIncrease> SalaryIncreases { get; set; }
        public virtual DbSet<SalaryPayment> SalaryPayments { get; set; }


        //   public DbSet<tbGunler> tbGunler { get; set; }
        //     public DbSet<tbIsBasvuruIsHayati> tbIsBasvuruIsHayati { get; set; }
        // public DbSet<EmployeeRating> PersonalRating { get; set; }


        #endregion
    }
}
