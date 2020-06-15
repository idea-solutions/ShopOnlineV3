namespace Domain.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool CategoryParent { get; set; }
        public int SubCategoryId { get; set; }
    }
}