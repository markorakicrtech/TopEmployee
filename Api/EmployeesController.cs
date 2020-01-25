using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopEmployee.Dtos;

namespace TopEmployee.Api
{
    public class EmployeesController : ApiController
    {
        private Models.AplicationDBContext _context;
        private MapperConfiguration config;
        public EmployeesController(MapperConfiguration config)
        {
            this.config = config;
        }
        public EmployeesController()
        {
            _context = new Models.AplicationDBContext();
        }
        // GET : /api/employee
        public EmployeeDto GetEmployee(int id)
        {
            var emp = _context.Employees.Where(x => x.EmployeeId == id)
                .ProjectTo<EmployeeDto>(config)
                .FirstOrDefault();
            if (emp == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return emp;
        }
    }
}
