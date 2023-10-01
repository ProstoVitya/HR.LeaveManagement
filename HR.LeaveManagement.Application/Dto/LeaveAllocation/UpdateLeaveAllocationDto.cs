using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto.LeaveAllocation;

public class UpdateLeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int PeriodId { get; set; }
}