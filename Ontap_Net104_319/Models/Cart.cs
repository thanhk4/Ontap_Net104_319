namespace Ontap_Net104_319.Models
{
    public class Cart
    {
        public string UseName { get; set; }
        public int Status { get; set; }

        public Account Account { get; set; }
        public virtual List<CartDetail> CartDetails { get; set; }
    }
}
