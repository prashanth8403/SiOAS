using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiOAS
{
    public class Timex
    {
        public static int counter;
        public Timex()
        {
            counter = 1800;
        }
        public string Compute()
        {
            counter--;
            TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(counter--));
            string rx = time.ToString(@"hh\:mm\:ss");
            return rx;
        }
    }
}