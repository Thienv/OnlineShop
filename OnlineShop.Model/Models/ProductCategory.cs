using TeduShop.Model.Abstract;

namespace OnlineShop.Model.Models
{
    public class ProductCategory : Auditable
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }
    }
}