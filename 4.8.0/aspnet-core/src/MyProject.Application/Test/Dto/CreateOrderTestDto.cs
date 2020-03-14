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
        public void Normalize()
        {
            
        }
    }
}
