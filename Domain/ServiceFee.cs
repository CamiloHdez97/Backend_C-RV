namespace Domain;

public class ServiceFee : BaseEntityA {

    public ICollection<Service> ? Services {get;set;}
    public int ? FeePorcent {get;set;}

}