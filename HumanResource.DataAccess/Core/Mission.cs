using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionId { get; set; }
        [MaxLength(100)]
        public string Missionary { get; set; } //görevi veren
        public DateTime MissionBeginDate { get; set; }
        public DateTime MissionEndDate { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string MissionNotes { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string Description { get; set; }


        [DefaultValue(1)]
        public bool MissionStatus { get; set; }
        [DefaultValue(0)]
        public bool MissionIsDeleted { get; set; }

        public virtual ICollection<EmployeeMission> EmployeeMissions { get; set; }
    }


    enum MissionStatus
    {

        NotInitialize = 0,
        Start = 1,
        Continue = 2,
        Finish = 3

    }
}
