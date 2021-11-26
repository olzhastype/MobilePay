using System;

namespace MobilePay.Model
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
        /// <summary>
        /// Идет как идентификатор платильщика 
        /// </summary>
        public string SenderName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
