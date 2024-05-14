namespace Ontap_Net104_319.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public int Amount { get ; set; }
        
        public virtual List<BuilDetail> BuilDetails { get; set; }
        public virtual List<CartDetail> Cartdetails { get; set; } 

    }
}
    