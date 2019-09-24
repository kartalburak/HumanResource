using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string MessageContent { get; set; }
        public DateTime MessageSendDate { get; set; }
        [MaxLength(100)]
        public string MessageTitle { get; set; }
        [MaxLength(100)]
        public string MessageSubject { get; set; }
        public bool MessageIsRead { get; set; }
        [DefaultValue(1)]
        public bool MessageStatus { get; set; }
        [DefaultValue(0)]
        public bool MessageIsDeleted { get; set; }





        public virtual ICollection<EmployeeMessage> EmployeeMessages { get; set; }


    }
}
