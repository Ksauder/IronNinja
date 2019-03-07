using System;

namespace IronNinja2{

    class Equipment{

        private string name;
        public string Name{
            get{
                return name;
            }
        }
        private double defenseAttrib;
        public double DefenseAttrib{
            get{
                return defenseAttrib;
            }
        }
        private double offensiveAttrib;
        public double OffensiveAttrib{
            get{
                return offensiveAttrib;
            }
        }
        private enum slot{
            Chest, Leg, MainHand, OffHand, Cape, Helm, Ammo
        }


    }
}