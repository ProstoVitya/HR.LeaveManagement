using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto.LeaveRequest;

public class UpdateLeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public string RequestComments { get; set; }
    public bool Cancelled { get; set; }
}