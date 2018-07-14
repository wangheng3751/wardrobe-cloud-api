using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using WardrobeCloud.Clothes;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeCloud.DressCollocation
{
    public class DressCollocationItem:Entity
    {
        [ForeignKey("DressCollocationId")]
        public virtual DressCollocation DressCollocation { get; set; }
        [ForeignKey("ClothesId")]
        public virtual Clothes.Clothes Clothes { get; set; }
    }
}
