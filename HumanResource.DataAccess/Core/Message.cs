using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public int PersonalID { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public string Header { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }





        public virtual IEnumerable<Employee> Employee { get; set; }


    }
}
