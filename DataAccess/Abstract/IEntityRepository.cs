using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetByID(T Entity);
        List<T> GetByBrandId(T Entity);
        List<T> GetByColorID(T Entity);
        List<T> GetAll();
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
