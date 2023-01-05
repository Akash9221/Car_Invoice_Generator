using System;

namespace Cab_Invoice_Generator
{
    public class Fare
    {
        public double CostPerKm = 10;
        public int CostPerMinute = 1;
        public int MinimumFare = 5;

        public double CalculateFare(double Distance,int time)
        {
            double Fare=(CostPerKm*Distance)+(CostPerMinute*time);
            return Math.Max(Fare,MinimumFare);  
        }
    }
    internal class CarInvoice
    {
        static void Main(string[] args)
        {
            
        }
    }
}
