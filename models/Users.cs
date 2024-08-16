using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ecomers_dotnet;
[Table("users")]
public class Users
{
    [Column(name:"id")]
    public int Id {get;set;}
    [Column(name:"username")]
    public string Username {get;set;}
    [Column(name:"name")]
    public string Name {get;set;}
    [Column(name:"birthday")]
    public DateOnly? Birthday {get;set;}
    [Column(name:"password")]
    public string Password {get;set;}
    [ForeignKey(nameof(Roles))]
    [Column(name:"role_id")]
    [Required]
    public int RoleId {get;set;}
    public ICollection<Orders> Orders {get;set;}
    public Roles Role {get;set;}
    [Column(name:"creation_date")]
    public DateTime CreationDate {get;set;}
    [Column(name:"update_date")]
    public DateTime UpdateDate {get;set;}
}
