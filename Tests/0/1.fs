type Details = 
    { Name: string
      Description: string }

type Item = 
    { Details: Details }

type Exit = 
    | PassableExit of Details * destination: Room
    | LockedExit of Details * key: Item * next: Exit
    | NoExit of Details option

and Exits = 
    { North: Exit
      South: Exit
      East: Exit
      West: Exit }

and Room = 
    { Details: Details
      Items: Item list
      Exits: Exits }

let fRoom = 
    { Details = {Name = "First Room"; Description = "Welcome"};
    Items = [];
    Exits = 
        { North = NoExit(None);
          South = NoExit(None);
          East = NoExit(None);
          West = NoExit(None); }}
