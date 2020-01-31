using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timesheet.business;
using timesheet.data;

namespace timesheet.api.controllers
{
    [Route("api/v1/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly TimesheetDb _db;
        private readonly EmployeeService employeeService;
        public EmployeeController(TimesheetDb db)
        {
            _db = db;
            this.employeeService = new EmployeeService(_db);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(string text)
        {
            var items = this.employeeService.GetEmployees();
            return new ObjectResult(items);
        }
    }
}