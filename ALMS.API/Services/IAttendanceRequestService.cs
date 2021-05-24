﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Services
{
    interface IAttendanceRequestService
    {
        List<TrattendanceDetail> GetTrAttendanceDetails();
        TrattendanceDetail GetTrAttendanceDetail(int AttendanceId);
        bool AddTrAttendanceDetail(TrattendanceDetail trAttendanceDetail);
        bool DeleteTrAttendanceDetail(int AttendanceId);
        bool UpdateTrAttendanceDetail(TrattendanceDetail trAttendanceDetail);
    }
}
