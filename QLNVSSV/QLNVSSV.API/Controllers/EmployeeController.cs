using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.Models.Modes;
using QLNVSSV.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseAPIController<Employee>
    {
        private IWebHostEnvironment _hostingEnvironment;

        private readonly IEmployeeRepository _employeeRepository;


        public EmployeeController(IEmployeeRepository employeeRepository,IWebHostEnvironment environment,IBaseRepository<Employee> baseRepository):base(baseRepository)
        {
            _employeeRepository = employeeRepository;
            _hostingEnvironment = environment;
        }

        [HttpGet("GetApproval")]
        public IActionResult GetbyProc()
        {
            var proc = $"Proc_GetByStatus @status ";
            const int status = 0;
            var obj = new object[] {status};
            var data = _baseRepository.GetByProc(proc, obj);

            return Ok(data);
        }

        [HttpGet("UpdateStatus/{id}/{status}")]
        public IActionResult UpdateStatus(int id,int status)
        {
            var proc = $"Proc_UpdateStatus @employeeId , @status ";
            var obj = new object[] { id, status };
            var result = _baseRepository.Update(proc, obj);
            var test = new ServiceResponse();

            return Ok(result);
        }
        
        public FileResult Dowloadfile(string pathfile)
        {
            string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Image/") + pathfile;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/pdf", pathfile);
        }

        public IActionResult GetbyProcPost()
        {
            return Ok();
        }
    }
}
