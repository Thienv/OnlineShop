namespace OnlineShop.Model.Models
{
    public class PostTag
    {
        public int PostId { set; get; }

        public string TagId { set; get; }

        public virtual Post Post { set; get; }

        public virtual Tag Tag { set; get; }
    }
}