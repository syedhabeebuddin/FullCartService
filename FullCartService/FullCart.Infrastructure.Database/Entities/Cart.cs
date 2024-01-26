namespace FullCart.Infrastructure.Database.Entities
{
    public class Cart : BaseEntity
    {
        public int CartDetailId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual User User { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
