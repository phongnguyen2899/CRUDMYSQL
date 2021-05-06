using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.Models.Modes;
using QLNVSSV.Models.ViewModel;
using System.IO;

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



        [HttpGet("GetEmployeeStatus/{status}")]
        public IActionResult GetEmployeeStatus(int status)
        {
            var data = _employeeRepository.GetEmployeebyStatus(status);

            return Ok(data);
        }

        [HttpGet("GetEmployeeSendMail/{status}")]
        public IActionResult GetEmployeeSendMail(int status)
        {
            var data = _employeeRepository.GetEmployeeSendMail(status);

            return Ok(data);
        }

        [HttpGet("UpdateStatus/{id}/{status}")]
        public IActionResult UpdateStatus(int id,int status)
        {
            var result = _employeeRepository.UpdateStatusEmployee(id, status);

            return Ok(result);
        }
        
        [HttpGet("Dowloadfile/{pathfile}")]
        public FileResult Dowloadfile(string pathfile)
        {
            string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Image/") + pathfile;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/pdf", pathfile);
        }


        [HttpPost("GetbyfilterAproval")]
        public IActionResult GetbyfilterAproval([FromBody]ApprovalFillterViewModel approvalFillterViewModel)
        {
            var data = _employeeRepository.GetbyfilterAproval(approvalFillterViewModel);
            return Ok(data);
        }

        [HttpPut("UpdateSolidarity")]
        public IActionResult UpdateSolidarity([FromBody]UpdateSolidarityViewModel updateSolidarityViewModel)
        {
            var result = _employeeRepository.UpdateSolidarity(updateSolidarityViewModel.employeeId,updateSolidarityViewModel.solidarity,updateSolidarityViewModel.interviewtime);
            return Ok(result);
        }
    }
}
