namespace Domain;

public class Telephone : BaseEntityA {

    public ICollection<TypeContact> ? TypeContact {get;set;}
    public int ? MobileNumber {get;set;}
    public int ? TelephoneNumber {get;set;} 

}