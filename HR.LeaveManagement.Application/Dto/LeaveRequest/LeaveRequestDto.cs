﻿using HR.LeaveManagement.Application.Dto.Common;
using HR.LeaveManagement.Application.Dto.LeaveType;

namespace HR.LeaveManagement.Application.Dto.LeaveRequest;

public class LeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequest { get; set; }
    public string RequestComments { get; set; }
    public DateTime? DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}