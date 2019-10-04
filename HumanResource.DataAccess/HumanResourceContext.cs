using HumanResource.DataAccess.Core;
using Microsoft.EntityFrameworkCore;

namespace HumanResource.DataAccess
{
    public class HumanResourceContext : DbContext
    {
        public HumanResourceContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity => { entity.HasKey(e => e.EmployeeId); });


            #region RelationShipOnTables

            #region Activity-ManyToMany
            modelBuilder.Entity<ActivityEmployee>().HasKey(ae => new { ae.ActivityId, ae.EmployeeId });
            modelBuilder.Entity<ActivityEmployee>().HasOne(ae => ae.Activity).WithMany(a => a.ActivityEmployees).HasForeignKey(ae => ae.ActivityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ActivityEmployee>().HasOne(ae => ae.Employee).WithMany(e => e.ActivityEmployees).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict); ;

            modelBuilder.Entity<ActivityBranch>().HasKey(ab => new { ab.ActivityId, ab.BranchId });
            modelBuilder.Entity<ActivityBranch>().HasOne(ab => ab.Activity).WithMany(a => a.ActivityBranches).HasForeignKey(ab => ab.ActivityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ActivityBranch>().HasOne(ab => ab.Branch).WithMany(b => b.ActivityBranches).HasForeignKey(ab => ab.BranchId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ActivityDepartment>().HasKey(ae => new { ae.ActivityId, ae.DepartmentId });
            modelBuilder.Entity<ActivityDepartment>().HasOne(ae => ae.Activity).WithMany(a => a.ActivityDepartments).HasForeignKey(ae => ae.ActivityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ActivityDepartment>().HasOne(ae => ae.Department).WithMany(e => e.ActivityDepartments).HasForeignKey(ae => ae.DepartmentId).OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Advertisement-ManyToMany 

            modelBuilder.Entity<AdvertisementBranch>().HasKey(ae => new { ae.AdvertisementId, ae.BranchId });
            modelBuilder.Entity<AdvertisementBranch>().HasOne(ae => ae.Advertisement).WithMany(a => a.AdvertisementBranches).HasForeignKey(ae => ae.AdvertisementId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AdvertisementBranch>().HasOne(ae => ae.Branch).WithMany(e => e.AdvertisementBranches).HasForeignKey(ae => ae.BranchId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AdvertisementDepartment>().HasKey(ae => new { ae.AdvertisementId, ae.DepartmentId });
            modelBuilder.Entity<AdvertisementDepartment>().HasOne(ae => ae.Advertisement).WithMany(a => a.AdvertisementDepartments).HasForeignKey(ae => ae.AdvertisementId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AdvertisementDepartment>().HasOne(ae => ae.Department).WithMany(e => e.AdvertisementDepartments).HasForeignKey(ae => ae.DepartmentId).OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Announcement-ManyToMany 

            modelBuilder.Entity<AnnouncementBranch>().HasKey(ae => new { ae.AnnouncementId, ae.BranchId });
            modelBuilder.Entity<AnnouncementBranch>().HasOne(ae => ae.Announcement).WithMany(a => a.AnnouncementBranches).HasForeignKey(ae => ae.AnnouncementId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AnnouncementBranch>().HasOne(ae => ae.Branch).WithMany(e => e.AnnouncementBranches).HasForeignKey(ae => ae.BranchId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AnnouncementEmployee>().HasKey(ae => new { ae.AnnouncementId, ae.EmployeeId });
            modelBuilder.Entity<AnnouncementEmployee>().HasOne(ae => ae.Announcement).WithMany(a => a.AnnouncementEmployees).HasForeignKey(ae => ae.AnnouncementId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AnnouncementEmployee>().HasOne(ae => ae.Employee).WithMany(e => e.AnnouncementEmployees).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<AnnouncementDepartment>().HasKey(ae => new { ae.AnnouncementId, ae.DepartmentId });
            modelBuilder.Entity<AnnouncementDepartment>().HasOne(ae => ae.Announcement).WithMany(a => a.AnnouncementDepartments).HasForeignKey(ae => ae.AnnouncementId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<AnnouncementDepartment>().HasOne(ae => ae.Department).WithMany(e => e.AnnouncementDepartments).HasForeignKey(ae => ae.DepartmentId).OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Branch-ManyToMany

            modelBuilder.Entity<BranchEducation>().HasKey(ae => new { ae.BranchId, ae.EducationId });
            modelBuilder.Entity<BranchEducation>().HasOne(ae => ae.Branch).WithMany(a => a.BranchEducations).HasForeignKey(ae => ae.BranchId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BranchEducation>().HasOne(ae => ae.Education).WithMany(e => e.BranchEducations).HasForeignKey(ae => ae.EducationId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BranchDepartment>().HasKey(ae => new { ae.BranchId, ae.DepartmentId });
            modelBuilder.Entity<BranchDepartment>().HasOne(ae => ae.Branch).WithMany(a => a.BranchDepartments).HasForeignKey(ae => ae.BranchId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BranchDepartment>().HasOne(ae => ae.Department).WithMany(e => e.BranchDepartments).HasForeignKey(ae => ae.DepartmentId).OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Department-ManyToMany

            modelBuilder.Entity<DepartmentEducation>().HasKey(ae => new { ae.DepartmentId, ae.EducationId });
            modelBuilder.Entity<DepartmentEducation>().HasOne(ae => ae.Education).WithMany(a => a.DepartmentEducations).HasForeignKey(ae => ae.EducationId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DepartmentEducation>().HasOne(ae => ae.Department).WithMany(e => e.DepartmentEducations).HasForeignKey(ae => ae.DepartmentId).OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Education-ManyToMany

            modelBuilder.Entity<EducationEmployee>().HasKey(ae => new { ae.EducationId, ae.EmployeeId });
            modelBuilder.Entity<EducationEmployee>().HasOne(ae => ae.Education).WithMany(a => a.EducationEmployees).HasForeignKey(ae => ae.EducationId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EducationEmployee>().HasOne(ae => ae.Employee).WithMany(e => e.EducationEmployees).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Employee-ManyToMany

            modelBuilder.Entity<EmployeeMessage>().HasKey(ae => new { ae.MessageId, ae.EmployeeId });
            modelBuilder.Entity<EmployeeMessage>().HasOne(ae => ae.Message).WithMany(a => a.EmployeeMessages).HasForeignKey(ae => ae.MessageId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeMessage>().HasOne(ae => ae.Employee).WithMany(e => e.EmployeeMessages).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeMission>().HasKey(ae => new { ae.MissionId, ae.EmployeeId });
            modelBuilder.Entity<EmployeeMission>().HasOne(ae => ae.Mission).WithMany(a => a.EmployeeMissions).HasForeignKey(ae => ae.MissionId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeMission>().HasOne(ae => ae.Employee).WithMany(e => e.EmployeeMissions).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeePermit>().HasKey(ae => new { ae.PermitId, ae.EmployeeId });
            modelBuilder.Entity<EmployeePermit>().HasOne(ae => ae.Permit).WithMany(a => a.EmployeePermits).HasForeignKey(ae => ae.PermitId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeePermit>().HasOne(ae => ae.Employee).WithMany(e => e.EmployeePermits).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeReference>().HasKey(ae => new { ae.ReferenceId, ae.EmployeeId });
            modelBuilder.Entity<EmployeeReference>().HasOne(ae => ae.Reference).WithMany(a => a.EmployeeReferences).HasForeignKey(ae => ae.ReferenceId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeReference>().HasOne(ae => ae.Employee).WithMany(e => e.EmployeeReferences).HasForeignKey(ae => ae.EmployeeId).OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region JobApplication-ManyToMany
            modelBuilder.Entity<JobApplicationLanguage>().HasKey(ae => new { ae.JobApplicationId, ae.LanguageId });
            modelBuilder.Entity<JobApplicationLanguage>().HasOne(ae => ae.JobApplication).WithMany(a => a.JobApplicationLanguages).HasForeignKey(ae => ae.JobApplicationId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<JobApplicationLanguage>().HasOne(ae => ae.Language).WithMany(e => e.JobApplicationLanguages).HasForeignKey(ae => ae.LanguageId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobApplicationReference>().HasKey(ae => new { ae.JobApplicationId, ae.ReferenceId });
            modelBuilder.Entity<JobApplicationReference>().HasOne(ae => ae.JobApplication).WithMany(a => a.JobApplicationReferences).HasForeignKey(ae => ae.JobApplicationId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<JobApplicationReference>().HasOne(ae => ae.Reference).WithMany(e => e.JobApplicationReferences).HasForeignKey(ae => ae.ReferenceId).OnDelete(DeleteBehavior.Restrict);
            #endregion


            #endregion

        }

        #region DbSets

        public virtual DbSet<Activity> Activities { get; set; }

        public virtual DbSet<Advertisement> Advertisements { get; set; }

        public virtual DbSet<Announcement> Announcements { get; set; }

        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Education> Educations { get; set; }

        // public virtual DbSet<EducationDetail> EducationDetails { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        //  public virtual DbSet<EmployeeIO> EmployeeIos { get; set; }

        public virtual DbSet<EmployeeRating> EmployeeRatings { get; set; }

        public virtual DbSet<IncapacityReport> IncapacityReports { get; set; }

        public virtual DbSet<JobApplication> JobApplications { get; set; }

        public virtual DbSet<Language> Languages { get; set; }

        public virtual DbSet<Log> Logs { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<Mission> Missions { get; set; }

        //   public virtual DbSet<Plan> Plans { get; set; }

        public virtual DbSet<Permit> Permits { get; set; }

        public virtual DbSet<Reference> References { get; set; }

        //   public virtual DbSet<SalaryIncrease> SalaryIncreases { get; set; }
        //   public virtual DbSet<SalaryPayment> SalaryPayments { get; set; }


        //   public DbSet<tbGunler> tbGunler { get; set; }
        //     public DbSet<tbIsBasvuruIsHayati> tbIsBasvuruIsHayati { get; set; }
        // public DbSet<EmployeeRating> PersonalRating { get; set; }


        #endregion
    }
}
