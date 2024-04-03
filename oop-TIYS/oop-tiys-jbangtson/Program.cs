using Classes;

//Let's add some robots, helpers, and houses.
//Remember, robots can have multiple helpers and houses can have multiple robots.
Robot greenRobot = new Robot("Robert", "green", 0.5);
Robot blueRobot = new Robot("Julie", "blue", 0.75);

Helper yellowHelper = new Helper("Helper 1", "yellow", 1);
Helper purpleHelper = new Helper("Helper 2", "purple", 1);

House niceHouse = new House("2000 Future Ave.", "silver");
House oldHouse = new House("88 Lame Street", "brown"); 



//Now let's add these robots to some houses.
//I'm going to give both of the robots the nice house to share.
niceHouse.robotHome.Add(greenRobot);
niceHouse.robotHome.Add(blueRobot);



//Next, let's give both robots a helper!
greenRobot.helperList.Add(yellowHelper);
blueRobot.helperList.Add(purpleHelper);



//If we wanted to see the amount of robots in each house we could run this code:
Console.WriteLine($"There are {niceHouse.robotHome.Count} robots at {niceHouse.Address}");
Console.WriteLine($"There are {oldHouse.robotHome.Count} robots at {oldHouse.Address}");



//If we wanted to list the robots IDs and names in the nice house to get a closer look we could use a for loop to iterate over the list:
Console.WriteLine($"\nThe robots at {niceHouse.Address} are:");
for(int x = 0; x < niceHouse.robotHome.Count; x++){
    Console.WriteLine($"ID: {niceHouse.robotHome[x].RobotID} Name: {niceHouse.robotHome[x].Name}");
}



//Finally, if we wanted to see the helpers within the nice house we can use nested-for loops:
Console.WriteLine($"\nThe helpers at {niceHouse.Address} are:");
for(int x = 0; x < niceHouse.robotHome.Count; x++){

    for(int z = 0; z < niceHouse.robotHome[x].helperList.Count; z++){

        Console.WriteLine($"ID: {niceHouse.robotHome[x].helperList[z].helperID} Name: {niceHouse.robotHome[x].helperList[z].Name} Owned by: {niceHouse.robotHome[x].Name}");
    
    }
}