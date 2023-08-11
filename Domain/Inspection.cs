namespace Domain;
public class Inspection : BaseEntityA
{
    public ICollection<Door> ? Doors {get;set;}
    public ICollection<Cabine> ? Cabines {get;set;}
    public DateTime DateofEntry {get;set;}
    public string ? DiagCustomer {get;set;}
    public int Id_Vehicle {get;set;}
    public Vehicle ? Vehicle {get;set;}
}