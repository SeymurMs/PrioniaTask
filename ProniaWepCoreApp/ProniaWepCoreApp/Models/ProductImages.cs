namespace ProniaWepCoreApp.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
