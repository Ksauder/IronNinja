using System;
using System.Collections.Generic;

namespace IronNinja2{
    class Human{
        // Attributes
        protected string _name;
        protected int _health;
        protected int _maxHP;
        protected double _equipmentBonus;
        public double EquipmentBonus{
            get{
                return _equipmentBonus;
            }
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
            rand.NextDouble()
            int dmg = calcDamage();
            return dmg;
        }

        protected int calcDamage(Human target){
            int damage = 0;
            double offensiveBonus = 0;
            double defensiveBonus = 0;
            foreach(KeyValuePair<string, Equipment> entry in WornEquipment){
                offensiveBonus += entry.Value.OffensiveAttrib;
            }
            foreach(KeyValuePair<string, Equipment> entry in target.WornEquipment)

            return damage;
        }
    }

}

// Damage formula
// .5 * A(Effective level= 1.0-1.25 or %100-%125)