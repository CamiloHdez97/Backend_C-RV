using System.ComponentModel.DataAnnotations;

namespace Domain;

public class BaseEntityA{
    [Key]
    public int Id {get;set;}
}