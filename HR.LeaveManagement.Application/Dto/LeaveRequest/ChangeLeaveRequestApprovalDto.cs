using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto.LeaveRequest;

public class ChangeLeaveRequestApprovalDto : BaseDto
{
    public bool? Approval { get; set; }
}