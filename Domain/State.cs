namespace Domain;

public class State : BaseEntityA {

    public ICollection<OrderService> ? OrderServices {get;set;}
    public string ? Description {get;set;}

}