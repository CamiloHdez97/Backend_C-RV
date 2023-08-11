namespace Domain;

public class SquarePart : BaseEntityA {

    public ICollection<RelPartsOrder> ? RelPartsOrders {get;set;}
    public int Id_Nit {get;set;}
    public Provider ? Provider {get;set;}
    public string ? Description {get;set;}
    public double ? price {get;set;}
    public string ? Brand {get;set;}

}