using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class GSMTest
    {
        GSM[] gsmList = new GSM[]
        {
            new GSM("Xperia Z3", "Sony"),
            new GSM("Zenphone 2", "Asus")
        };

        public void DisplayInfo()
        {
            foreach (var gsm in this.gsmList)
            {
                Console.WriteLine(gsm.ToString());
            }
        }

        public static void DisplayIPhone()
        {
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
