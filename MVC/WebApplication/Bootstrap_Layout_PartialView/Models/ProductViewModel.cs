namespace Bootstrap_Layout_PartialView.Models
{
    public class ProductViewModel
    {
        public Product? product { get; set; }
        public string? CategoryName { get; set; }
        public bool isInStock { get; set; }
        public string? Message { get; set; }
    }
}
