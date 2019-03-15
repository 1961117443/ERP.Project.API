using Admin.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.IService
{
    public interface ICustomerService:IBaseService<Customer>
    {
        /// <summary>
        /// 用户注册
        /// </summary>
        void Register();
        void UpdateModule();
        void RegisterModuel();
        void GetModuleList();
        void Get();
        void Update();
    }
}
