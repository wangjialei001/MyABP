using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using MyProject.Test.Dto;

namespace MyProject.Test
{
    /// <summary>
    /// 订单测试
    /// </summary>
    [AbpAuthorize]
    public class OrderTestAppService : AsyncCrudAppService<OrderTest, OrderTestDto, int, PagedOrderTestResultRequestDto, CreateOrderTestDto, OrderTestDto>, IOrderTestAppService
    {
        private readonly IRepository<OrderTest, int> repository;
        private readonly IObjectMapper objectMapper;
        public OrderTestAppService(IRepository<OrderTest, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            this.repository = repository;
            this.objectMapper = objectMapper;
        }
        /// <summary>
        /// 订单测试创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override async Task<OrderTestDto> Create(CreateOrderTestDto input)
        {
            var order = objectMapper.Map<OrderTest>(input);
            var newOrder = await repository.InsertAsync(order);
            var result = objectMapper.Map<OrderTestDto>(newOrder);
            return await Task.FromResult(result);
        }

        //public Task Delete(EntityDto<int> input)
        //{
        //    return Task.FromResult(0);
        //}
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override async Task<OrderTestDto> Get(EntityDto<int> input)
        {
            var order = await repository.FirstOrDefaultAsync(t => t.Id == input.Id);
            return objectMapper.Map<OrderTestDto>(order);
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override async Task<PagedResultDto<OrderTestDto>> GetAll(PagedOrderTestResultRequestDto input)
        {
            var query = repository.GetAllIncluding(null);
            query = query.Skip(input.SkipCount).Take(input.MaxResultCount);
            var items = new List<OrderTestDto>();

            var result = new PagedResultDto<OrderTestDto> { Items = new List<OrderTestDto> { } };
            query.ToList().ForEach(t =>
            {
                var item = objectMapper.Map<OrderTestDto>(t);
                items.Add(item);
            });
            result.Items = items;
            return await Task.FromResult(result);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override async Task<OrderTestDto> Update(OrderTestDto input)
        {
            var order = await repository.FirstOrDefaultAsync(t => t.Id == input.Id);
            order.Count = input.Count;
            var newOrder = await repository.UpdateAsync(order);
            var result = objectMapper.Map<OrderTestDto>(newOrder);
            return await Task.FromResult(result);
        }
    }
}
