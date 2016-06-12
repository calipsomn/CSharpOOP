using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public static class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM gsmTest = new GSM("Galaxy S7", "Samsung");
            gsmTest.AddCall(new Call(DateTime.Now, 200, "088 876123"));
            gsmTest.AddCall(new Call(DateTime.Now, 20, "088 876123"));
            gsmTest.AddCall(new Call(DateTime.Now, 60, "088 876123"));
            gsmTest.AddCall(new Call(DateTime.Now, 300, "088 876123"));

            for (int ind = 0; ind < gsmTest.CallHistory.Count; ind++)
            {
                Console.WriteLine(String.Format("Call {0}:\n {1}", ind, gsmTest.CallHistory[ind].ToString()));
            }

            Console.WriteLine(String.Format("The price of the calls is {0:C}", gsmTest.TotalCallPrice(0.37m)));
            var indToDelete = 0;
            int maxDuration = 0;
            for (int ind = 0; ind < gsmTest.CallHistory.Count; ind++)
                if (gsmTest.CallHistory[ind].DurationInSeconds > maxDuration)
                {
                    maxDuration = gsmTest.CallHistory[ind].DurationInSeconds;
                    indToDelete = ind;
                }
            gsmTest.DeleteCall(gsmTest.CallHistory[indToDelete]);
            Console.WriteLine(String.Format("The price of the calls after deleting the longest call is {0:C}", 
                gsmTest.TotalCallPrice(0.37m)));
            gsmTest.ClearHistory();
            Console.WriteLine("The number of calls after deleting the history is {0}", gsmTest.CallHistory.Count);
        }
    }
}
