interface IConsumable{
    int Calories {get;set;}
    bool IsSpicy {get;set;}
    bool IsSweet {get;set;}
    
    string GetInfo();
}   
