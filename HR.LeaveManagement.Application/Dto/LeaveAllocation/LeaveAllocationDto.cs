using HR.LeaveManagement.Application.Dto.Common;
using HR.LeaveManagement.Application.Dto.LeaveType;

namespace HR.LeaveManagement.Application.Dto.LeaveAllocation;

public class LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}