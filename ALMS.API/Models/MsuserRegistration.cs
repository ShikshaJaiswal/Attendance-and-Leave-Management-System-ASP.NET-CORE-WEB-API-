using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsuserRegistration
    {
        
        [Required(ErrorMessage ="EmployeeId is required")]        
        public long? EmployeeId { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        //public virtual MsemployeeDetail Employee { get; set; }
    }
}
