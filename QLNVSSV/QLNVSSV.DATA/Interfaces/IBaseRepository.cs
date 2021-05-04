using QLNVSSV.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNVSSV.DATA.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T>  Get();

        T GetById(int id );
        ServiceResponse Insert(T entity);
        ServiceResponse Update(T entity);
        int Delete(object id);
        ServiceResponse GetCountRecord();
    }
}
