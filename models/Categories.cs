using System.ComponentModel.DataAnnotations.Schema;

namespace ecomers_dotnet;
[Table("categories")]
public class Categories
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"category")]
    public string Category {get;set;}
    public ICollection<Products> Products {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
