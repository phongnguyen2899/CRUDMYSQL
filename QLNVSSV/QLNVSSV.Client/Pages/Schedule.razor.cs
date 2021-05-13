using QLNVSSV.Client.ApiIntergration;
using QLNVSSV.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.Client.Pages
{
    public partial class Schedule
    {
        public List<QLNVSSV.Models.Modes.Employee> listEmployee { get; set; } = new();
        public List<QLNVSSV.Models.Modes.Employee> listInterviewer { get; set; } = new();

        public string ModalClass { get; set; }

        public string DissplayModal { get; set; } = "none";

        public void Open()
        {
            DissplayModal = "block;";
            ModalClass = "show";
            StateHasChanged();
        }
        public void Close()
        {
            DissplayModal = "none";
            ModalClass = "";
            StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            listEmployee =await GetData<QLNVSSV.Models.Modes.Employee>.GetList("http://localhost:37919/api/Employee/GetEmployeeSendMail/1");
            listInterviewer =await ApiIntergration.GetData<QLNVSSV.Models.Modes.Employee>.GetList("http://localhost:37919/api/Employee/GetEmployeeStatus/13");
        }


        public QLNVSSV.Models.Modes.Employee employee { get; set; } = new();
        public async Task Show(int id)
        {
            var url = $"http://localhost:37919/api/Employee/{id}'";
            employee = await ApiIntergration.GetData<QLNVSSV.Models.Modes.Employee>.GetById($"http://localhost:37919/api/Employee/{id}");
            Open();
        }
        public async Task Imsposed()
        {
            string url = "http://localhost:37919/api/Employee/UpdateSchedule";
            UpdateScheduleViewModel model = new UpdateScheduleViewModel()
            {
                EmployeeId = employee.EmployeeId,
                InterviewerId = employee.InterviewerId,
                InterviewAddress = employee.InterviewAddress,
                InterviewTime = employee.InterviewTime
            };

           await ApiIntergration.GetData<UpdateScheduleViewModel>.Put(url,model);
            Close();

        }
    }
}
