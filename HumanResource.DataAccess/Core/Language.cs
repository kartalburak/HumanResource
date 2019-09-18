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
        public int BasvuruID { get; set; }
        public string LanguageName { get; set; }
        public string Read { get; set; }
        public string Write { get; set; }
        public string Speak { get; set; }
        public string Understand { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }







    }
}
