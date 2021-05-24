using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.UI.Models
{
    public class MsProjectLoginDetail
    {
        [Required(ErrorMessage = "ProjectId Name Required")]
        public int? ProjectId { get; set; }
        [Required(ErrorMessage = "Employee Id Required")]
        public long? EmployeeId { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string ProjectPassword { get; set; }
    }
}
