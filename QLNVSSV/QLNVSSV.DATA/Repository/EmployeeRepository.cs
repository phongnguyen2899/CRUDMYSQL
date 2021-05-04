using QLNVSSV.DATA.Database;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.Models.Modes;
using QLNVSSV.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNVSSV.DATA.Repository
{
    public class EmployeeRepository:BaseRepository<Employee>,IEmployeeRepository
    {
        protected IDatabaseContext<EmployeeUpdateViewModel> _databaseContextuc;
        public EmployeeRepository( IDatabaseContext<EmployeeUpdateViewModel> databaseContextuc,IDatabaseContext<Employee> databaseContext) : base(databaseContext)
        {
            _databaseContextuc = databaseContextuc;
        }
    }
}
