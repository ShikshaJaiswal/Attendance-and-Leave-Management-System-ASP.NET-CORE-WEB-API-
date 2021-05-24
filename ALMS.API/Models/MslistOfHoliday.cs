using System;
using System.Collections.Generic;

#nullable disable

namespace ALMS.API.Models
{
    public partial class MslistOfHoliday
    {
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }
    }
}
