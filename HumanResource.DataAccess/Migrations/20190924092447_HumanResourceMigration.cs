using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResource.DataAccess.Migrations
{
    public partial class HumanResourceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    ActivityName = table.Column<string>(maxLength: 100, nullable: true),
                    ActivityDescription = table.Column<string>(maxLength: 500, nullable: true),
                    ActivityDate = table.Column<DateTime>(nullable: false),
                    ActivityCapacity = table.Column<int>(nullable: false),
                    ActivityStatus = table.Column<bool>(nullable: false),
                    ActivityIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertisementTitle = table.Column<string>(maxLength: 100, nullable: true),
                    AdvertisementName = table.Column<string>(maxLength: 100, nullable: true),
                    AdvertisementBeginDate = table.Column<DateTime>(nullable: false),
                    AdvertisementEndDate = table.Column<DateTime>(nullable: false),
                    AdvertisementJobDescription = table.Column<string>(maxLength: 2147483647, nullable: true),
                    AdvertisementDescription = table.Column<string>(maxLength: 2147483647, nullable: true),
                    AdvertisementExperience = table.Column<string>(maxLength: 500, nullable: true),
                    AdvertisementEducationLevel = table.Column<string>(maxLength: 100, nullable: true),
                    AdvertisementPositionLevel = table.Column<string>(maxLength: 100, nullable: true),
                    AdvertisementWayOfWorking = table.Column<string>(maxLength: 50, nullable: true),
                    AdvertisementPersonelNumber = table.Column<int>(nullable: false),
                    AdvertisementCountry = table.Column<string>(maxLength: 50, nullable: true),
                    AdvertisementCity = table.Column<string>(maxLength: 50, nullable: true),
                    AdvertisementMilitary = table.Column<string>(maxLength: 50, nullable: true),
                    AdvertisementViewsCount = table.Column<int>(nullable: false),
                    AdvertisementIsStatus = table.Column<bool>(nullable: false),
                    AdvertisementIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementID);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnnouncementName = table.Column<string>(maxLength: 100, nullable: false),
                    AnnouncementDescription = table.Column<string>(maxLength: 100, nullable: false),
                    AnnouncementBeginDate = table.Column<DateTime>(nullable: false),
                    AnnouncementEndDate = table.Column<DateTime>(nullable: false),
                    AnnouncementTitle = table.Column<string>(maxLength: 100, nullable: false),
                    AnnouncementContent = table.Column<string>(maxLength: 2147483647, nullable: false),
                    AnnouncementStatus = table.Column<bool>(nullable: false),
                    AnnouncementIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.AnnouncementID);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BranchName = table.Column<string>(maxLength: 100, nullable: false),
                    BranchCode = table.Column<string>(maxLength: 20, nullable: false),
                    BranchDescription = table.Column<string>(maxLength: 200, nullable: true),
                    BranchTelephone = table.Column<string>(maxLength: 50, nullable: false),
                    BranchAddress = table.Column<string>(maxLength: 500, nullable: false),
                    BranchFax = table.Column<string>(maxLength: 100, nullable: true),
                    BranchStatus = table.Column<bool>(nullable: false),
                    BranchIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(maxLength: 100, nullable: false),
                    DepartmentDescription = table.Column<string>(maxLength: 200, nullable: true),
                    DepartmentManager = table.Column<string>(maxLength: 100, nullable: true),
                    DepartmentStatus = table.Column<bool>(nullable: false),
                    DepartmentIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationName = table.Column<string>(maxLength: 100, nullable: false),
                    EducationBeginDate = table.Column<DateTime>(nullable: false),
                    EducationEndDate = table.Column<DateTime>(nullable: false),
                    EducationCapacity = table.Column<int>(nullable: false),
                    EducationTrainerTitle = table.Column<string>(maxLength: 100, nullable: true),
                    EducationTrainerName = table.Column<string>(maxLength: 50, nullable: true),
                    EducationTrainerSurname = table.Column<string>(maxLength: 50, nullable: true),
                    EducationTrainerTelephone = table.Column<string>(maxLength: 11, nullable: true),
                    EducationsNotes = table.Column<string>(maxLength: 2147483647, nullable: true),
                    EducationIsMandatory = table.Column<bool>(nullable: false),
                    EducationStatus = table.Column<bool>(nullable: false),
                    EducationIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationID);
                });

            migrationBuilder.CreateTable(
                name: "IncapacityReport",
                columns: table => new
                {
                    IncapacityReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    VisaDate = table.Column<DateTime>(nullable: false),
                    Hospital = table.Column<string>(nullable: true),
                    Polyclinic = table.Column<string>(nullable: true),
                    PolyclinicDate = table.Column<DateTime>(nullable: false),
                    Diagnostic = table.Column<string>(nullable: true),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    NextControl = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    JobAccident = table.Column<bool>(nullable: false),
                    JobDisease = table.Column<bool>(nullable: false),
                    Disease = table.Column<bool>(nullable: false),
                    PeriodicControl = table.Column<bool>(nullable: false),
                    PatientNameSurname = table.Column<string>(nullable: true),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Diploma = table.Column<string>(nullable: true),
                    PatentNumber = table.Column<string>(nullable: true),
                    IncapacityReportIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncapacityReport", x => x.IncapacityReportId);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageName = table.Column<string>(nullable: true),
                    LanguageRead = table.Column<string>(nullable: true),
                    LanguageWrite = table.Column<string>(nullable: true),
                    LanguageSpeak = table.Column<string>(nullable: true),
                    LanguageUnderstand = table.Column<string>(nullable: true),
                    LanguageStatus = table.Column<bool>(nullable: false),
                    LanguageIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessageContent = table.Column<string>(maxLength: 2147483647, nullable: true),
                    MessageSendDate = table.Column<DateTime>(nullable: false),
                    MessageTitle = table.Column<string>(maxLength: 100, nullable: true),
                    MessageSubject = table.Column<string>(maxLength: 100, nullable: true),
                    MessageIsRead = table.Column<bool>(nullable: false),
                    MessageStatus = table.Column<bool>(nullable: false),
                    MessageIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    MissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Missionary = table.Column<string>(maxLength: 100, nullable: true),
                    MissionBeginDate = table.Column<DateTime>(nullable: false),
                    MissionEndDate = table.Column<DateTime>(nullable: false),
                    MissionNotes = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Description = table.Column<string>(maxLength: 2147483647, nullable: true),
                    MissionStatus = table.Column<bool>(nullable: false),
                    MissionIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.MissionId);
                });

            migrationBuilder.CreateTable(
                name: "Permit",
                columns: table => new
                {
                    PermitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PermitBeginDate = table.Column<DateTime>(nullable: false),
                    PermitEndDate = table.Column<DateTime>(nullable: false),
                    PermitReason = table.Column<string>(maxLength: 2147483647, nullable: true),
                    PermitRequestDate = table.Column<DateTime>(nullable: false),
                    PermitConfirm = table.Column<bool>(nullable: false),
                    PermitNotes = table.Column<string>(maxLength: 2147483647, nullable: true),
                    PermitStatus = table.Column<bool>(nullable: false),
                    PermitIsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permit", x => x.PermitId);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    ReferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReferenceName = table.Column<string>(maxLength: 100, nullable: false),
                    ReferenceSurname = table.Column<string>(maxLength: 100, nullable: false),
                    ReferenceCompanyName = table.Column<string>(maxLength: 100, nullable: false),
                    ReferenceAddress = table.Column<string>(maxLength: 2147483647, nullable: true),
                    ReferenceTelephone = table.Column<string>(maxLength: 11, nullable: false),
                    ReferenceTitle = table.Column<string>(maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.ReferenceID);
                });

            migrationBuilder.CreateTable(
                name: "ActivityBranch",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityBranch", x => new { x.ActivityId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_ActivityBranch_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityBranch_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementBranch",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementBranch", x => new { x.AdvertisementId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_AdvertisementBranch_Advertisement_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisement",
                        principalColumn: "AdvertisementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementBranch_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementBranch",
                columns: table => new
                {
                    AnnouncementId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementBranch", x => new { x.AnnouncementId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_AnnouncementBranch_Announcement_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcement",
                        principalColumn: "AnnouncementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnnouncementBranch_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityDepartment",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDepartment", x => new { x.ActivityId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_ActivityDepartment_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementDepartment",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementDepartment", x => new { x.AdvertisementId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_AdvertisementDepartment_Advertisement_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisement",
                        principalColumn: "AdvertisementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementDepartment",
                columns: table => new
                {
                    AnnouncementId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementDepartment", x => new { x.AnnouncementId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_AnnouncementDepartment_Announcement_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcement",
                        principalColumn: "AnnouncementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnnouncementDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchDepartment",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDepartment", x => new { x.BranchId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_BranchDepartment_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IncapacityReportId = table.Column<int>(nullable: false),
                    EmployeeCode = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeUsername = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeePassword = table.Column<string>(maxLength: 100, nullable: false),
                    EmployeeTitle = table.Column<string>(maxLength: 100, nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeSurname = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeBirthdate = table.Column<DateTime>(nullable: false),
                    EmployeeEmail = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeCompanyMail = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeBirthplace = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeTelephone1 = table.Column<string>(maxLength: 11, nullable: false),
                    EmployeeTelephone2 = table.Column<string>(maxLength: 11, nullable: true),
                    EmployeeIsSmoke = table.Column<bool>(nullable: false),
                    EmployeeBloodGroup = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeTc = table.Column<string>(maxLength: 11, nullable: false),
                    EmployeeMarialStatus = table.Column<bool>(nullable: false),
                    EmployeeGender = table.Column<string>(maxLength: 10, nullable: false),
                    EmployeeCountry = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeCity = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeStreet = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeBuildNo = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeePostcode = table.Column<string>(maxLength: 10, nullable: true),
                    EmployeeMilitaryDate = table.Column<DateTime>(nullable: false),
                    EmployeeMilitaryStatus = table.Column<string>(maxLength: 20, nullable: false),
                    EmployeeBankName = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeIban = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeBankCode = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeIsDrivingLicense = table.Column<bool>(nullable: false),
                    EmployeeDrivingLicenseName = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeImagePath = table.Column<string>(maxLength: 250, nullable: true),
                    EmployeeRegisteredDate = table.Column<DateTime>(nullable: false),
                    EmployeeWifeNameSurname = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeWifeBirthdate = table.Column<DateTime>(nullable: false),
                    EmployeeWifeTelephone = table.Column<string>(maxLength: 11, nullable: true),
                    EmployeeWifeTCKN = table.Column<string>(maxLength: 11, nullable: true),
                    EmployeeSSKFirstBeginDate = table.Column<DateTime>(nullable: false),
                    EmployeeWorkBeginDate = table.Column<DateTime>(nullable: false),
                    EmployeeWorkOutDate = table.Column<DateTime>(nullable: false),
                    EmployeeLanguage1 = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeLanguage2 = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeLanguage3 = table.Column<string>(maxLength: 20, nullable: true),
                    EmployeeReferenceNameSurname = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeReferenceNotes = table.Column<string>(maxLength: 500, nullable: true),
                    EmployeeReferenceTelephone = table.Column<string>(maxLength: 11, nullable: true),
                    EmployeeChildrenCount = table.Column<int>(nullable: false),
                    EmployeeGraduationSchool = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeGraduationDepartment = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeGraduationScore = table.Column<decimal>(nullable: false),
                    EmployeeManager = table.Column<string>(maxLength: 100, nullable: true),
                    EmployeeDisabilitySituation = table.Column<bool>(nullable: false),
                    EmployeeSGKNumber = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeNotes = table.Column<string>(maxLength: 2147483647, nullable: true),
                    EmployeeStatus = table.Column<bool>(nullable: false),
                    EmployeeIsDeleted = table.Column<bool>(nullable: false),
                    AdvertisementID = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    BranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Advertisement_AdvertisementID",
                        column: x => x.AdvertisementID,
                        principalTable: "Advertisement",
                        principalColumn: "AdvertisementID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchEducation",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchEducation", x => new { x.BranchId, x.EducationId });
                    table.ForeignKey(
                        name: "FK_BranchEducation_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchEducation_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "EducationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEducation",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEducation", x => new { x.DepartmentId, x.EducationId });
                    table.ForeignKey(
                        name: "FK_DepartmentEducation_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEducation_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "EducationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityEmployee",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityEmployee", x => new { x.ActivityId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_ActivityEmployee_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementEmployee",
                columns: table => new
                {
                    AnnouncementId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementEmployee", x => new { x.AnnouncementId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_AnnouncementEmployee_Announcement_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcement",
                        principalColumn: "AnnouncementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnnouncementEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationEmployee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEmployee", x => new { x.EducationId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EducationEmployee_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "EducationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationEmployee_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMessage",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMessage", x => new { x.MessageId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeMessage_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeMessage_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMission",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    MissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMission", x => new { x.MissionId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeMission_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeMission_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePermit",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    PermitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePermit", x => new { x.PermitId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeePermit_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePermit_Permit_PermitId",
                        column: x => x.PermitId,
                        principalTable: "Permit",
                        principalColumn: "PermitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRating",
                columns: table => new
                {
                    EmployeeRatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeRatingEvaluative = table.Column<string>(maxLength: 2147483647, nullable: true),
                    EmployeeRatingRateDate = table.Column<DateTime>(nullable: false),
                    EmployeeRatingResult = table.Column<string>(maxLength: 2147483647, nullable: true),
                    EmployeeRatingStatus = table.Column<bool>(nullable: false),
                    EmployeeIsDeleted = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRating", x => x.EmployeeRatingId);
                    table.ForeignKey(
                        name: "FK_EmployeeRating_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeReference",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    ReferenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeReference", x => new { x.ReferenceId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeReference_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeReference_Reference_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "Reference",
                        principalColumn: "ReferenceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameSurname = table.Column<string>(nullable: true),
                    Birthplace = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    ChildNumber = table.Column<string>(nullable: true),
                    ChildAge = table.Column<string>(nullable: true),
                    WifeName = table.Column<string>(nullable: true),
                    WifeEducation = table.Column<string>(nullable: true),
                    WifeJob = table.Column<string>(nullable: true),
                    WifeJobAddress = table.Column<string>(nullable: true),
                    JobPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    MilitaryStatus = table.Column<string>(nullable: true),
                    IsDrivingLicense = table.Column<bool>(nullable: false),
                    LicenseClass = table.Column<string>(nullable: true),
                    IsCriminalRecord = table.Column<bool>(nullable: false),
                    LicenseDate = table.Column<DateTime>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    SchoolCity = table.Column<string>(nullable: true),
                    SchoolDegree = table.Column<string>(nullable: true),
                    ExpectedSalary = table.Column<double>(nullable: false),
                    JobApplicationStatus = table.Column<bool>(nullable: false),
                    JobApplicationIsDeleted = table.Column<bool>(nullable: false),
                    BranchId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_JobApplication_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobApplication_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogDate = table.Column<DateTime>(nullable: false),
                    LogMessage = table.Column<string>(maxLength: 50, nullable: true),
                    LogActionName = table.Column<string>(maxLength: 50, nullable: true),
                    LogControllerName = table.Column<string>(maxLength: 50, nullable: true),
                    LogType = table.Column<string>(maxLength: 50, nullable: true),
                    LogStatus = table.Column<bool>(nullable: false),
                    LogIsDeleted = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_Log_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationLanguage",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationLanguage", x => new { x.JobApplicationId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_JobApplicationLanguage_JobApplication_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "JobApplication",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplicationLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationReference",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(nullable: false),
                    ReferenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationReference", x => new { x.JobApplicationId, x.ReferenceId });
                    table.ForeignKey(
                        name: "FK_JobApplicationReference_JobApplication_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "JobApplication",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplicationReference_Reference_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "Reference",
                        principalColumn: "ReferenceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityBranch_BranchId",
                table: "ActivityBranch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDepartment_DepartmentId",
                table: "ActivityDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityEmployee_EmployeeId",
                table: "ActivityEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementBranch_BranchId",
                table: "AdvertisementBranch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementDepartment_DepartmentId",
                table: "AdvertisementDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementBranch_BranchId",
                table: "AnnouncementBranch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementDepartment_DepartmentId",
                table: "AnnouncementDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementEmployee_EmployeeId",
                table: "AnnouncementEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartment_DepartmentId",
                table: "BranchDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchEducation_EducationId",
                table: "BranchEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEducation_EducationId",
                table: "DepartmentEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEmployee_EmployeeId",
                table: "EducationEmployee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AdvertisementID",
                table: "Employee",
                column: "AdvertisementID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchId",
                table: "Employee",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMessage_EmployeeId",
                table: "EmployeeMessage",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMission_EmployeeId",
                table: "EmployeeMission",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePermit_EmployeeId",
                table: "EmployeePermit",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRating_EmployeeId",
                table: "EmployeeRating",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReference_EmployeeId",
                table: "EmployeeReference",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_BranchId",
                table: "JobApplication",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_EmployeeId",
                table: "JobApplication",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationLanguage_LanguageId",
                table: "JobApplicationLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationReference_ReferenceId",
                table: "JobApplicationReference",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_EmployeeId",
                table: "Log",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityBranch");

            migrationBuilder.DropTable(
                name: "ActivityDepartment");

            migrationBuilder.DropTable(
                name: "ActivityEmployee");

            migrationBuilder.DropTable(
                name: "AdvertisementBranch");

            migrationBuilder.DropTable(
                name: "AdvertisementDepartment");

            migrationBuilder.DropTable(
                name: "AnnouncementBranch");

            migrationBuilder.DropTable(
                name: "AnnouncementDepartment");

            migrationBuilder.DropTable(
                name: "AnnouncementEmployee");

            migrationBuilder.DropTable(
                name: "BranchDepartment");

            migrationBuilder.DropTable(
                name: "BranchEducation");

            migrationBuilder.DropTable(
                name: "DepartmentEducation");

            migrationBuilder.DropTable(
                name: "EducationEmployee");

            migrationBuilder.DropTable(
                name: "EmployeeMessage");

            migrationBuilder.DropTable(
                name: "EmployeeMission");

            migrationBuilder.DropTable(
                name: "EmployeePermit");

            migrationBuilder.DropTable(
                name: "EmployeeRating");

            migrationBuilder.DropTable(
                name: "EmployeeReference");

            migrationBuilder.DropTable(
                name: "IncapacityReport");

            migrationBuilder.DropTable(
                name: "JobApplicationLanguage");

            migrationBuilder.DropTable(
                name: "JobApplicationReference");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "JobApplication");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
