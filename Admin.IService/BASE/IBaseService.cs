using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.IService
{
    public interface IBaseService<T>
    {
        void Add(T entity);
    }
}
