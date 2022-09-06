using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace employeeService.Controllers
{
    public class EmployeeController : ApiController
    {[Authorize]
        public IEnumerable<employeeTBL> Get()
        {
            using (employeesEntities entities = new employeesEntities())
            {

                return entities.employeeTBLs.ToList();
            }

        }
    }
}
