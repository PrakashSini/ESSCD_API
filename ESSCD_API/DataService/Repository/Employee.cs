using AutoMapper;
using ESSCD_API.Models;
using ESSCD_API.Services.DbConnection;
using Microsoft.EntityFrameworkCore;

namespace ESSCD_API.DataService.Repository
{
    public class Employee :IEmployee
    {
        private readonly AppdbContext _context;
        private readonly IMapper _mapper;

        public Employee(AppdbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Response> GetAllEmployeeShifWise()
        {
            Response response = new Response();
            try
            {
                var employees = await _context.Shifts.Include(e => e.Employee).ToListAsync();
                var finalData = _mapper.Map<List<EmployeeShiftDTO>>(employees);

                response.Data = finalData;
                response.StatusCode = "Success!";

            }
            catch (Exception ex) 
            {
                response.StatusCode = "Error";
                response.Message = ex.Message;
            }


            return response;

        }

    }
}
