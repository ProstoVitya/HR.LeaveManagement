using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto;

public class LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}