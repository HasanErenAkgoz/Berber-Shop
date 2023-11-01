using System;

namespace Core.Entities
{
    public class BaseEntity : BaseEntity<int> { }
    public class BaseEntity<T> : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual int CreateUserId { get; set; }
        public virtual int UpdateUserId { get; set; }
        public virtual DateTime UpdateDate { get; set; }    
        public virtual DateTime CreateDate { get; set; }   
        public virtual bool IsStatus { get; set; }
        public virtual bool IsDeleted { get; set;}
    }
}
