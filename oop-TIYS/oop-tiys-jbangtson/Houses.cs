namespace Classes;

public class House
{
    
    
    public string Address {get; set;}
    public string Color {get; set;}


    public List<Robot> robotHome = new List<Robot>{};


    // Constructor Method
    public House(string address, string color)
    {
        Address = address;
    
        Color = color;
        

    
    }

        
    
   
    
    
}