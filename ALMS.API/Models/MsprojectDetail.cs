using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MsprojectDetail
    {
        //public MsprojectDetail()
        //{
        //    TrattendanceDetails = new HashSet<TrattendanceDetail>();
        //    TrprojectAllocations = new HashSet<TrprojectAllocation>();
        //}
        [Key]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Project Name Required")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Project Name Required")]
        public string ProjectTechnology { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public string Status { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        //public virtual ICollection<TrattendanceDetail> TrattendanceDetails { get; set; }
        //public virtual ICollection<TrprojectAllocation> TrprojectAllocations { get; set; }
    }
}
