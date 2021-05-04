using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace QLNVSSV.DATA.Interfaces
{
    public interface IDatabaseContext<T>
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(string storeName);
        object Get(string storeName, string code);
        T GetById(object id);
        int Insert(T entity);
        int Update(T entity);
        int DeleteById(object id);
        bool CheckDuplicate(T entity, PropertyInfo property, bool isAddNew);
        int GetCountRecord();
    }
}
