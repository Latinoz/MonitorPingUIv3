using System;
using System.IO;

namespace MonitorPingUI
{
    class Logging
    {
        public static void DoLog(string namelog, string text)
        {
            using (StreamWriter w = File.AppendText(namelog + ".txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  ");
                w.WriteLine(":{0}", text);
                w.WriteLine("-------------------------------");

            }

        }

    }
}
