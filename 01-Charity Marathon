namespace Т01_CharrityMarathon
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int daysMarathon = int.Parse(Console.ReadLine());  
            long runersNum = long.Parse(Console.ReadLine());
            int averageNumberLapsEveryRynner = int.Parse(Console.ReadLine());
            long trackLengh = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyKm = double.Parse(Console.ReadLine());

  
            var totalRunsMetres = Math.Min(runersNum, (trackCapacity * daysMarathon));
            var kilometersTotal = (totalRunsMetres * averageNumberLapsEveryRynner * trackLengh)/1000;

            Console.WriteLine($"Money raised: {moneyKm * kilometersTotal:F2}");

       }
    }
}





