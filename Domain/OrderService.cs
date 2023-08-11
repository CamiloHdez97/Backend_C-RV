namespace Domain;

public class OrderService : BaseEntityA
{
    public ICollection<RepairOrder> ? RepairOrders {get;set;}
    public int Id_City {get;set;}
    public City ? City {get;set;}
    public int Id_Vehicle {get;set;}
    public int Id_Inspection {get;set;}
    public ICollection<Inspection> ? Inspections {get;set;}
    public int Id_state {get;set;}
    public State ? State {get;set;}

}