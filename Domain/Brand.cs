using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Brand : BaseEntityA 
{
    public ICollection<Vehicle> ? Vehicles {get;set;}
    public string ? Description {get;set;}
}