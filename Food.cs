using System;

namespace IronNinja2{
        class Food : HealingItem, IConsumable{

        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo(){
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool spicy, bool sweet){
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }


}