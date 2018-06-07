using Serenity.Services;

namespace CoreDevAdmin.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}