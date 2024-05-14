namespace Ontap_Net104_319.Models
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Usename { get; set; } // id cart
        public int Quantity { get; set; }
        public int Status { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }

    }
}
