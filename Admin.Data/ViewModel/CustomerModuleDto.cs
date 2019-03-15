using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Data.ViewModel
{
    public class CustomerModuleDto
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public string ModuleID { get; set; }
        /// <summary>
        /// 模块名
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpTime { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
