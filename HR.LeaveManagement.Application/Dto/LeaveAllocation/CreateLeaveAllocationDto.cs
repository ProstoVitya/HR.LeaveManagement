﻿namespace HR.LeaveManagement.Application.Dto.LeaveAllocation;

public class CreateLeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}