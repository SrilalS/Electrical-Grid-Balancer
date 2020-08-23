using System;
using System.Collections.Generic;

namespace GridBalancer
{
    class PowerSource
    {
        public String Name;
        public double Energy;
        public int type;
        public Boolean isVariable;
        public double variableThreshold;

        public PowerSource(String Name, double Energy, int type, Boolean isVariable, double variableThreshold)
        {
            //0Nuclear 1Coal 2Gas 3Hydro 4Diesel 5Solar 6Wind
            this.Name = Name;
            this.Energy = Energy;
            this.type = type;
            this.isVariable = isVariable;
            this.variableThreshold = variableThreshold;
        }

        public String getPType()
        {
            string[] PTypes = {"Nuclear", "Coal", "Gas" ,"Hydro", "Diesel", "Solar", "Wind"};

            return PTypes[this.type];
         }
    }
}
