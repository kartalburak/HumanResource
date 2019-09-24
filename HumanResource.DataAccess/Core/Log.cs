using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int LogId { get; set; }
        [Required]
        public DateTime LogDate { get; set; }
        [MaxLength(50)]
        public string LogMessage { get; set; }
        [MaxLength(50)]
        public string LogActionName { get; set; }
        [MaxLength(50)]
        public string LogControllerName { get; set; }
        [MaxLength(50)]
        public string LogType { get; set; }
        [DefaultValue(1)]
        public bool LogStatus { get; set; }
        [DefaultValue(0)]
        public bool LogIsDeleted { get; set; }


        public virtual Employee Employee { get; set; }
    }
}
