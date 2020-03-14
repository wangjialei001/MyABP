using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Test
{
    [Table("T_OrderTest")]
    public class OrderTest : Entity<int>, IHasCreationTime, ISoftDelete
    {
        public DateTime CreationTime { get; set; }
        [StringLength(20)]
        [Description("名称")]
        public string Name { get; set; }
        /// <summary>
        /// 销售时间
        /// </summary>
        public DateTime SaleTime { get; set; }
        [DefaultValue(0)]
        public int Count { get; set; }
        [MaxLength(500)]
        public string Producter { get; set; }
        public bool IsDeleted { get; set; }
    }
}
