using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Data.EntityModel;
using Admin.Data.ViewModel;
using Admin.IService;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    /// <summary>
    /// 客户API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMapper mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerService"></param>
        /// <param name="mapper"></param>
        public CustomerController(ICustomerService customerService,IMapper mapper)
        {
            this.customerService = customerService;
            this.mapper = mapper;
        }
        /// <summary>
        /// 获取单个用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get")]
        public async Task<IActionResult> Get(string id)
        {
            var entity = await customerService.Find(id);
            if (entity==null)
            {
                return BadRequest();
            }
            var model= this.mapper.Map<CustomerDto>(entity);
            return Ok(model);
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var list = customerService.Query();
            return Ok(list);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        [HttpPost("create")]
        public IActionResult Register(CustomerCreateDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            var entity= this.mapper.Map<Customer>(dto);
            entity.ID = Guid.NewGuid().ToString();
            customerService.Add(entity);
            return Ok(entity);
        } 
        
    }
}