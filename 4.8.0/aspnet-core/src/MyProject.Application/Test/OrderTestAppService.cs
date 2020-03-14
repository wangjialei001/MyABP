using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyProject.Test.Dto;

namespace MyProject.Test
{
    /// <summary>
    /// 订单测试
    /// </summary>
    [AbpAuthorize]
    public class OrderTestAppService : AsyncCrudAppService<OrderTest, OrderTestDto, int, PagedOrderTestResultRequestDto, CreateOrderTestDto, OrderTestDto>,IOrderTestAppService
    {
        public OrderTestAppService(IRepository<OrderTest, int> repository):base(repository)
        {

        }
        /// <summary>
        /// 订单测试创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override async Task<OrderTestDto> Create(CreateOrderTestDto input)
        {
            var result = new OrderTestDto { };
            return await Task.FromResult(result);
        }

        //public Task Delete(EntityDto<int> input)
        //{
        //    return Task.FromResult(0);
        //}

        public override async Task<OrderTestDto> Get(EntityDto<int> input)
        {
            var result = new OrderTestDto { };
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<OrderTestDto>> GetAll(PagedOrderTestResultRequestDto input)
        {
            var result = new PagedResultDto<OrderTestDto> { Items = new List<OrderTestDto> { } };
            return await Task.FromResult(result);
        }

        public override async Task<OrderTestDto> Update(OrderTestDto input)
        {
            var result = new OrderTestDto { };
            return await Task.FromResult(result);
        }
    }
}
