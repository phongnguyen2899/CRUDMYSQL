using QLNVSSV.Models.Modes;
using QLNVSSV.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNVSSV.DATA.Interfaces
{
    public interface IMailContentRepository:IBaseRepository<MailContent>
    {
        MailContent GetMailForemployee(int title);
        ServiceResponse Sendmail(int[] listEmployeeId);
    }
}
