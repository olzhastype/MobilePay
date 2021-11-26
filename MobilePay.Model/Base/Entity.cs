using System;

namespace MobilePay.Model
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
        public string SenderName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
