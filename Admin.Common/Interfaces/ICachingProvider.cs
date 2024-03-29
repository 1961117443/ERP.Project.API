﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Common.Interfaces
{
    public class ICachingProvider
    {
        /// <summary>
        /// 简单的缓存接口，只有查询和添加，以后会进行扩展
        /// </summary>
        public interface ICaching
        {
            object Get(string cacheKey);

            void Set(string cacheKey, object cacheValue);
        }
    }
}
