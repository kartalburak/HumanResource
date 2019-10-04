using System.ComponentModel.DataAnnotations;

namespace HumanResource.Models
{
    public class LoginViewModel
    {
        public string EmployeeUsername { get; set; }
        [DataType(DataType.Password)]
        public string EmployeePassword { get; set; }
        public bool IsChecked { get; set; }
    }
}
