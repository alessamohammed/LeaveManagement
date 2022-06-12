using LeaveManagement.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}