using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Language")]
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string LanguageRead { get; set; }
        public string LanguageWrite { get; set; }
        public string LanguageSpeak { get; set; }
        public string LanguageUnderstand { get; set; }
        [DefaultValue(1)]
        public bool LanguageStatus { get; set; }
        [DefaultValue(0)]
        public bool LanguageIsDeleted { get; set; }


        public virtual ICollection<JobApplicationLanguage> JobApplicationLanguages { get; set; }




    }
}
