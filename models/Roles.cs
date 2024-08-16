using System.ComponentModel.DataAnnotations.Schema;

namespace ecomers_dotnet;
[Table("roles")]
public class Roles
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"role")]
    public string Role {get;set;}
    public ICollection<Users> Users {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
