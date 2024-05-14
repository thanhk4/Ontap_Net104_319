namespace Ontap_Net104_319.Models
{
    public class BuilDetail
    {
         // 
        public Guid Id { get; set; }

        public Guid ProductID { get; set; }

        public string BuillId { get; set; }

        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }

        public virtual Product Product { get; set; } // 1 hóa đơn chi tiết có 1 sản phẩm
        public virtual Buil Buil { get; set; }

    }
}
