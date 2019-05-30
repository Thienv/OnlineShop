using TeduShop.Model.Abstract;

namespace OnlineShop.Model.Models
{
    public class Page : Auditable
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Content { set; get; }
    }
}