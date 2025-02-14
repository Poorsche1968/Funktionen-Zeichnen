using System;


namespace FunktionZeichnen
{
    public class ExponentialFunktion : Funktion
    {
        public double Base { get; set; }

        public ExponentialFunktion(double baseValue)
        {
            Base = baseValue;
        }

        public override double Berechne(double x)
        {
            return Math.Pow(Base, x);
        }
  
        public override string GetFunktionsTyp()
        {
            return "Exponential Function";
        }
    }
}

