using Admin.Data.EntityModel;
using Admin.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Service
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {

        public override async Task<Customer> Find(object id)
        {
            return GetData().Find(w => w.ID.Equals(id));
            //var customer = await Task.Run(() => new Customer
            //{
            //    Code = "0001",
            //    ComputeInfo = "GZM140",
            //    CreateTime = DateTime.Today.AddDays(-7),
            //    ID = Guid.NewGuid().ToString(),
            //    IsEnable = true,
            //    Name = "测试客户01",
            //    Password = "123456"
            //});
           // return customer;
        }
        public void GetModuleList()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void RegisterModuel()
        {
            throw new NotImplementedException();
        }

        public void UpdateModule()
        {
            throw new NotImplementedException();
        }
    }
}
