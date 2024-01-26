namespace FullCart.Infrastructure.Database.Entities
{
    public class Order : BaseEntity
    {
        public bool IsSuccessful { get; set; }
        public bool IsCancelled { get; set; }
        public decimal Amount { get; set; }
        public int CartDetailId { get; set; }
    }
}
