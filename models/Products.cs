using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecomers_dotnet;
[Table("products")]
public class Products
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"description")]
    public string Description {get;set;}
    [Required]
    [ForeignKey(nameof(Category))]
    [Column(name:"category_id")]
    public int CategoryId {get;set;}
    public ICollection<ProductsOrders> ProductsOrders {get;set;}
    public Categories Category {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
