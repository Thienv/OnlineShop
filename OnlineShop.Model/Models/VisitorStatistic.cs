using System;

namespace OnlineShop.Model.Models
{
    public class VisitorStatistic
    {
        public int Id { set; get; }

        public DateTime VisitedDate { set; get; }

        public string IPAddress { set; get; }
    }
}