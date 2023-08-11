namespace Domain; 

public class Vehicle : BaseEntityA {

    public ICollection<Inspection> ? Inspections {get;set;}
    public string ? CodPlate {get;set;}
    public string ? Model {get;set;}
    public int YearModel {get;set;}
    public int Id_Brand {get;set;}
    public Brand ? brand {get;set}
    public int Id_Person {get;set;}
    public Person ? Person {get;set;}


}