using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATEClient.Entity
{
    public class TestItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int OrderNo { get; set; }

        public int Status { get; set; }

        /// <summary>
        /// 开始测试时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束测试时间
        /// </summary>
        public DateTime EndTime { get; set; }

        public string TestFromNo { get; set; }
    }
}
