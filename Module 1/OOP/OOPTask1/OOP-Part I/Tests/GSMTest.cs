using System;


namespace OOP_Part_I
{
    public class GSMTest
    {
        public static void GSMTesting()
        {
            GSM[] arrOfGsm = new GSM[2];
            arrOfGsm[0] = new GSM("One", "HTC", 1300, "Prasko", new Battery("HTC", 50, 20, BatteryType.LiIon), new Display(15, 18000000));
            arrOfGsm[1] = new GSM("One", "HTC", 1300, "Prasko", new Battery("HTC", 50, 20, BatteryType.LiIon), new Display(15, 18000000));
            foreach (GSM gsm in arrOfGsm)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.Iphone4S);
        }
    }
}
