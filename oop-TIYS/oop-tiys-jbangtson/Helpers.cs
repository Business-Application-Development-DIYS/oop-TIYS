namespace Classes;

public class Helper
{


    public int helperID{get; private set;}
    public string Name {get; set;}
    public string Color {get; set;}
    public double BatteryLevel {get; set;}

    /*
    I'm using a static list here to keep track of all of the helper IDs so that they won't be reused by other helpers. 
    See the generateID function to see how I do this!
    */
    
    private static List<int> helperIDs = new List<int>{};

    // Constructor Method
    public Helper(string name, string color, double batterylevel)
    {
        helperID = generateID();
        Name = name;
        Color = color;
        BatteryLevel = batterylevel;

        checkBatteryLevel();
    }

    void checkBatteryLevel(){

        if(BatteryLevel > 1){
            BatteryLevel = 1;

        }
        else if(BatteryLevel < 0){
            BatteryLevel = 0;

        }
        
    }

    int generateID(){
        int id = 0;
        
        Random randomA = new Random();
        id = randomA.Next(1000,4000);

        if(helperIDs.Contains(id)){
            generateID();

        }


        return id;
    }
   
    
    
}