using QLNVSSV.Models.Modes;
using QLNVSSV.Models.ViewModel;
using QLNVSSV.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNVSSV.DATA.Interfaces
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeebyStatus(int status);
        ServiceResponse UpdateStatusEmployee(int id, int status);
        public IEnumerable<Employee> GetbyfilterAproval(ApprovalFillterViewModel approvalFillterViewModel);

        IEnumerable<Employee> GetEmployeeSendMail(int status);
        ServiceResponse UpdateSolidarity(int id, int solidarity,DateTime interviewtime);
    }
}
