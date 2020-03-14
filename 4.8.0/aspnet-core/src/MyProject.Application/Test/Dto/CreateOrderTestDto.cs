using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test.Dto
{
    [AutoMapTo(typeof(OrderTest))]
    public class CreateOrderTestDto : IShouldNormalize
    {
        public string Name { get; set; }
        public DateTime SaleTime { get; set; }
        public int Count { get; set; }
        public string ProducterName { get; set; }
        public void Normalize()
        {
            
        }
    }
}
