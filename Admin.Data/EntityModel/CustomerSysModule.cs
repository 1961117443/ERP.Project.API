using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Data.EntityModel
{
    /// <summary>
    /// 客户模块表
    /// </summary>
    public class CustomerSysModule
    {
        /// <summary>
        /// 主键id 自增类型
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 客户主键
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// 模块主键
        /// </summary>
        public string SysModuleID { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}
