using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Data.ViewModel
{
    /// <summary>
    /// 客户注册实体类
    /// </summary>
    public class CustomerRegisterDto
    {
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 注册的电脑信息
        /// </summary>
        public string ComputeInfo { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
