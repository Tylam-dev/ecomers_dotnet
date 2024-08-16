
using System.ComponentModel.DataAnnotations.Schema;
namespace ecomers_dotnet;
[Table("products_orders")]
public class ProductsOrders
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"product_id")]
    public Products Product {get;set;}
    public int ProductId {get;set;}
    [Column(name:"order_id")]
    public int OrderId {get;set;}
    public Orders Order {get;set;}
    [Column(name:"quantity")]
    public int Quantity {get;set;}
    [Column(name:"cost_unit")]
    public decimal CostUnit {get;set;}
    [NotMapped]
    public decimal TotalDetail {get;set;}
    [Column(name:"tax")]
    public decimal Tax {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
