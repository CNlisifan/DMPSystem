﻿using System;

namespace DMPSystem.Core.System.Intercept
{
    /// <summary>
    /// CacheKeyAttribute 自定义特性类
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property,
        AllowMultiple = false)]
    public class CacheKeyAttribute : Attribute
    {
    }
}
