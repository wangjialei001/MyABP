using Abp.AutoMapper;
using Abp.Modules;
using MyProject.Test;
using MyProject.Test.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class MyModule: AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateOrderTestDto, OrderTest>()
                      .ForMember(u => u.IsDeleted, options => options.Ignore())
                      .ForMember(u => u.Producter, options => options.MapFrom(input => input.ProducterName));
                config.CreateMap<OrderTestDto, OrderTest>()
                        .ForMember(u => u.IsDeleted, options => options.Ignore());
            });
        }
    }
}
