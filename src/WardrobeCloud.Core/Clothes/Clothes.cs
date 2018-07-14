using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeCloud.Clothes
{
    [Table("Clothes")]
    public class Clothes : Entity , ICreationAudited, IDeletionAudited
    {
        public virtual long? CreatorUserId { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeleterUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        [ForeignKey("ClothesCategoryId")]
        public virtual ClothesCategory Category { get; set; }        
        //图片地址
        public virtual string PictureUrl { get; set; }
        //图片托管地址
        public virtual string TrusteeshipPictureUrl { get; set; }
    }
}
