using System.ComponentModel.DataAnnotions;

namespace Dominio;
public class TypeContact {

    [Key]
    public int ? Id_TypeContact {get;set;}
    public ICollection<Contact> ? Contacts {get;set;}
    public string ? Email {get;set;}
    public int Id_Telephone {get;set}
    public Telephone ? Telephone {get;set;}

}
