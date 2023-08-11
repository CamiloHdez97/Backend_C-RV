namespace Domain;

public class Bill : BaseEntityA{
    public int Id_RepairOrder {get; set;}
    public RepairOrder ? RepairOrder {get;set;}
    public double ? TotalCostParts {get;set;}
    public double ? TotalService {get;set;}
    public double ? Total {get;set;}
}