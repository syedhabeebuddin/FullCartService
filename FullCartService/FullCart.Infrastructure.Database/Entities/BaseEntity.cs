namespace FullCart.Infrastructure.Database.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
