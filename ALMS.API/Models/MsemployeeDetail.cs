using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsemployeeDetail
    {
        //public MsemployeeDetail()
        //{
        //    TrattendanceDetails = new HashSet<TrattendanceDetail>();
        //    TrleaveRequestDetails = new HashSet<TrleaveRequestDetail>();
        //    TrprojectAllocations = new HashSet<TrprojectAllocation>();
        //}
        [Key]
        public long EmployeeId { get; set; }
        [Required(ErrorMessage ="Employee Name Required")]
        public string EmployeeName { get; set; }
        public DateTime EmployeeDob { get; set; }
        public int? EmployeeAge { get; set; }
        [Required(ErrorMessage = "Phone Number Required")]
        public long EmployeePhoneNumber { get; set; }
        [Required(ErrorMessage = "Email id Required")]
        [RegularExpression("^[a-z0-9_.]+[@]+[a-z0-9]+[.]+[a-z]+$", ErrorMessage ="Invalid Email Id")]
        public string EmployeeEmailId { get; set; }
        public string EmployeeAddress { get; set; }
        [Required(ErrorMessage = "Designation Required")]
        public string EmployeeDesignation { get; set; }
        public DateTime? EmployeeJoiningDate { get; set; }
        public long? ManagerId { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        //public virtual ICollection<TrattendanceDetail> TrattendanceDetails { get; set; }
        //public virtual ICollection<TrleaveRequestDetail> TrleaveRequestDetails { get; set; }
        //public virtual ICollection<TrprojectAllocation> TrprojectAllocations { get; set; }
    }
}
