using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.Models.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseAPIController<Employee>
    {
        private IBaseRepository<Employee> _baseRepository;
        public EmployeeController(IBaseRepository<Employee> baseRepository):base(baseRepository)
        {
            _baseRepository = baseRepository;
        }
    }
}
