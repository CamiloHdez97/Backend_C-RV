namespace Domain;

public class Arl : BaseEntityA
{
    public Icollection<Employe> ? Employes {get;set;}
    public string ? Description {get;set}
    
}