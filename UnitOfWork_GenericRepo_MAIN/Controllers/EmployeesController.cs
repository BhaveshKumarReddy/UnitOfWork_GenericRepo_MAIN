using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork_GenericRepo_MAIN.Models;
using UnitOfWork_GenericRepo_MAIN.Repository;

namespace UnitOfWork_GenericRepo_MAIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _uw;

        public EmployeesController(IUnitOfWork uw)
        {
            _uw = uw;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees() {
           return await _uw.Employee.GetAllAsync();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            return await _uw.Employee.GetAsync(x => x.Eid == id,"");
        }
    }
}
