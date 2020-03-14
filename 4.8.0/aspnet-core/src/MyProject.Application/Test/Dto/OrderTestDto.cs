using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
    [AutoMapFrom(typeof(OrderTest))]
    public class OrderTestDto: EntityDto<int>
    {
        public long Id { get; set; }
        public long MyId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 销售时间
        /// </summary>
        public DateTime SaleTime { get; set; }
        public int Count { get; set; }
    }
}
