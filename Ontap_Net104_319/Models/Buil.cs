namespace Ontap_Net104_319.Models
{
    public class Buil
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Decimal Money { get; set; }
        public string Usename { get; set; } //
        public int Status { get; set; } 

        // Quan hệ- Navigation 
        public virtual List<BuilDetail> Details { get; set; }
        public virtual Account Account { get; set; }
    }
}
