using System;
using System.Collections.Generic;

namespace IronNinja2{
    class Human{
        // Attributes
        protected string _name;
        public string Name{
            get{return _name;}
        }
        protected bool _isDead;
        public bool IsDead{
            get{ return _isDead; }
            set{;}
        }
        protected int _health;
        public int Health{
            get{ return _health; }
            set{;}
        }
        protected int _maxHP;
        protected double _equipmentBonus;
        public double EquipmentBonus{
            get{
                return _equipmentBonus;
            }
            set{;}
        }
        protected Dictionary<string,int> _skills = new Dictionary<string,int>{
            {"Strength", 1},
            {"Attack", 1}
        };


        protected Dictionary<string, Equipment> wornEquipment;
        public Dictionary<string, Equipment> WornEquipment{
            get{
                return WornEquipment;
            }
            set{;}
            
        }


        // Constructors
        public Human(string name){
            _name = name;
            _maxHP = 100;
            _health = _maxHP;
        }


        // Methods
        public int attack(Human target){
            Random rand = new Random();
            
            int dmg = Convert.ToInt32(rand.Next(_skills["Strength"]) * calcModifiers(target));

            target.hit(dmg);

            return dmg;
        }

        protected string eat(Food item){

            return Console.WriteLine($"{Name} ate {item.Name} and healed {item.HealsHP}")
        }

        protected double calcModifiers(Human target){
            double offensiveBonus = 1.0;
            double defensiveBonus = 0;

            // Calc instance's offensive modifiers
            foreach(KeyValuePair<string, Equipment> entry in WornEquipment){
                offensiveBonus += entry.Value.OffensiveAttrib;
            }

            // Calc target's defensive modifiers
            foreach(KeyValuePair<string, Equipment> entry in target.WornEquipment){
                defensiveBonus += entry.Value.DefenseAttrib;
            }

            return offensiveBonus - defensiveBonus;
        }

        public void hit (int dmg){
            _health -= dmg;
            if (_health <= 0){
                dead();
            }
        }

        protected void dead(){
            Console.WriteLine("He dead.");
            _isDead = true;
        }
    }

}

// Damage formula
// .5 * A(Effective level= 1.0-1.25 or %100-%125)