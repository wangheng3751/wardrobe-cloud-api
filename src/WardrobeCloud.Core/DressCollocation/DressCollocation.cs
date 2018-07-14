using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeCloud.DressCollocation
{
    [Table("DressCollocation")]
    public class DressCollocation:Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
