using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gsmTest = new GSMTest();
            gsmTest.DisplayInfo();
            GSMTest.DisplayIPhone();
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}
