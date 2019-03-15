using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data.ViewModel;
using Admin.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    /// <summary>
    /// 客户API
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string id)
        {
            return Ok();
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok();
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(CustomerRegisterDto dto)
        {
            return Ok();
        }

        /// <summary>
        /// 检查客户拥有的模块列表 
        /// </summary>
        /// <param name="id">客户id</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetModuleList(string id)
        {
            return Ok();
        }

        /// <summary>
        /// 客户注册模块
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modules"></param>
        /// <returns></returns>
        public IActionResult ModuleRegister(string id,string[] modules)
        {
            return Ok();
        }
    }
}