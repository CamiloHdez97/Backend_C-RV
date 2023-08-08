namespace Domain;

public class Cabine : BaseEntityA {

    public ICollection<Radio> ? Radios {get;set;}
    public ICollection<Upholstery> ? Upholsteries {get;set}
    public int Id_Inspection {get;set;}
    public Inspetion ? Inspection {get;set;}

}