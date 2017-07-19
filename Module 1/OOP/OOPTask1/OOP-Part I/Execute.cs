using System;
namespace OOP_Part_I
{
    public class Execute
    {
        static void Main()
        {
            GSM gsm = new GSM("3310", "Nokia", 2000, "Joro Chernoto Lale", new Battery("modelche", 500, 100,BatteryType.LiIon), new Display(15, 15000000));
            Console.WriteLine(gsm.ToString());
            GSMTest.GSMTesting();
            GSMCallHistoryTest.CallsTesting();
        }
    }
}
