using System;

namespace BulmaRazor.Components
{
    public class DataTableRowField
    {
        /// <summary>
        /// 字段值
        /// </summary>
        public  object Value { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// 字段显示值
        /// </summary>
        public string ShowValue { get; set; }
    }
}