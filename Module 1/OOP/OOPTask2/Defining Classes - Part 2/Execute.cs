using System;


namespace Defining_Classes___Part_2
{
    [CustomVersion]
    public class Execute
    {
        static void Main()
        {
            typeof(Execute).GetCustomAttributes(true);
            CustomVersion customAtt = new CustomVersion(new Version(2, 20));
            Console.WriteLine(customAtt.Version);
        }
    }
}
