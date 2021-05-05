using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using QLNVSSV.Models.Modes;
using QLNVSSV.Models.ViewModel;
using QLNVSSV.WebApp.ApiIntergration;
using static System.Net.WebRequestMethods;

namespace QLNVSSV.WebApp.Pages
{
    public class ApprovalModel : PageModel
    {
        public List<Employee> employee { get; set; }
        public List<Positions> listPositions { get; set; }
        public List<Title> listTitle { get; set; }
        public void OnGet()
        {
            employee = GetData<Employee>.GetList("http://localhost:37919/api/Employee/GetApproval");
            listPositions= GetData<Positions>.GetList("http://localhost:37919/api/Position/GetAll");
            listTitle=GetData<Title>.GetList("http://localhost:37919/api/Title/GetAll");
        }
        public void OnPost(ApprovalFillterViewModel model)
        {
            employee = GetData<Employee>.GetList("http://localhost:37919/api/Employee/GetAll");
            listTitle = GetData<Title>.GetList("http://localhost:37919/api/Title/GetAll");
            listPositions = GetData<Positions>.GetList("http://localhost:37919/api/Position/GetAll");
        }
        
    }
}
