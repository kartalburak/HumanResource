using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public string Content { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }

        [DefaultValue(0)]
        public bool IsDeleted { get; set; }


    }
}
