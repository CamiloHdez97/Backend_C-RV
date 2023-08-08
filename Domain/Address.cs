namespace Domain;

public class Address : BaseEntityA
{
    public string ? Neigborhood {get;set;}
    public string ? TypeWay {get;set;}
    public int NumberWay {get;set;}
    public string QuadrantPrefix {get; set;}
    public int FirstNumberPlate {get;set;}
    public int SecondNumberPlate {get;set;}
    public int Id_Pa {get;set;}   
    public Person ? Person {get;set;}
    public int Id_CityA {get;set;}
    public City ? City {get;set;}
}