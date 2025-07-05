using ESSCD_API.Models;

namespace ESSCD_API.DataService.Repository
{
    public interface IEmployee
    {
        Task<Response> GetAllEmployeeShifWise();
    }
}
