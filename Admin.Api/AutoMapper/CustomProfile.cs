using Admin.Data.EntityModel;
using Admin.Data.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Api.AutoMapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public CustomProfile()
        {
            EntityToView();
            ViewToEntity();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void EntityToView()
        {
            CreateMap<Customer, CustomerCreateDto>();
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void ViewToEntity()
        {
            CreateMap<CustomerCreateDto, Customer>();
        }
    }
}
