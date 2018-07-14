using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardrobeCloud.DressCollocation
{
    [Table("UserDressCollocationTag")]
    public class UserDressCollocationTag: Entity, ICreationAudited, IDeletionAudited
    {
        public virtual long? CreatorUserId { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeleterUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
