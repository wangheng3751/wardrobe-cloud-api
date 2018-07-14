using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeCloud.DressCollocation
{
    [Table("DressCollocationTag")]
    public class DressCollocationTag: Entity
    {
        [ForeignKey("DressCollocationId")]
        public virtual DressCollocation DressCollocation { get; set; }
        [ForeignKey("TagId")]
        public virtual UserDressCollocationTag Tag { get; set; }
    }
}
