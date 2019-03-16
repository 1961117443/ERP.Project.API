using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        /// <summary>
        /// 客户注册模块
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modules"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public IActionResult ModuleRegister(string id, string[] modules)
        {
            return Ok();
        }

        /// <summary>
        /// 检查客户拥有的模块列表 
        /// </summary>
        /// <param name="id">客户id</param>
        /// <returns></returns>
        [HttpGet("get")]
        public IActionResult GetModuleList(string id)
        {
            return Ok();
        }
    }
}