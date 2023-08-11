namespace Domain;

public class Service : BaseEntityA {

    public ICollection<RelServiceOrder> ? RelServiceOrders {get;set;}
    public int Id_ServiceFee {get;set;}
    public ServiceFee ? ServiceFee {get;set;}
    public int Id_RepairOrder {get;set;}
    public double ? TotalValue {get;set;}

}