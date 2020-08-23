using System;

namespace GridBalancer
{
    class PowerSource
    {
        public String Name;
        public double Energy;
        public Boolean isVariable;
        public double variableThreshold;

        public PowerSource(String Name, double Energy, Boolean isVariable, double variableThreshold)
        {
            this.Name = Name;
            this.Energy = Energy;
            this.isVariable = isVariable;
            this.variableThreshold = variableThreshold;
        }
    }
}
