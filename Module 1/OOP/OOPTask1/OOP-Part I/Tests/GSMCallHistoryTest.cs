using System;
using System.Linq;

namespace OOP_Part_I
{
    public class GSMCallHistoryTest
    {
        public static void CallsTesting()
        {
            GSM firstGsm = new GSM("S6Edge", "Samsung", 1000, "Koicho", new Battery("Samsung", 60, 200, BatteryType.LiIon), new Display(20, 60000000));
            firstGsm.CallHistory = new System.Collections.Generic.List<Calls>();
            firstGsm.AddCall(DateTime.Now, "+35987854647", 10);
            firstGsm.AddCall(DateTime.Now, "My love <3333", 32767);
            firstGsm.AddCall(DateTime.Now, "Bai Ivan", 1);
            foreach (Calls call in firstGsm.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("Total price:{0}",firstGsm.TotalPriceOfCalls());
            firstGsm.CallHistory = firstGsm.CallHistory.OrderBy(x => x.CallTime).ToList();
            firstGsm.DeleteCall(0);
            firstGsm.ClearCalls();
            foreach (Calls call in firstGsm.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
