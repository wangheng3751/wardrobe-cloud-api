using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace WardrobeCloud.Clothes
{
    public class ClothesCategory:Entity
    {
        public virtual string Name { get; set; }
    }
}
