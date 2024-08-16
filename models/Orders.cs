
using System.ComponentModel.DataAnnotations.Schema;

namespace ecomers_dotnet;
[Table("orders")]
public class Orders
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"user_id")]
    [ForeignKey(nameof(Users))]
    public int? UserId {get;set;}
    public Users? Users {get;set;}
    [NotMapped]
    public decimal Total {get;set;}
    public ICollection<ProductsOrders> ProductsOrders {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
