using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Announcement")]
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string AnnouncementContent { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }



        public virtual IEnumerable<Employee> Employee { get; set; }


    }
}
