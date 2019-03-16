using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Data.ViewModel
{
    public class CustomerDto
    {
        /// <summary>
        /// 主键ID 一般为guid类型
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 注册的电脑信息
        /// </summary>
        public string ComputeInfo { get; set; }
        /// <summary>
        /// 注册后的登陆账号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
