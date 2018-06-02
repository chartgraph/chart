using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

             Process process = new Process()
            {
                StartInfo = new ProcessStartInfo(@"\Chart.Graph\src\Wave.Graph.ex_ ", "Data.xml")
                {
                    WindowStyle = ProcessWindowStyle.Normal,
                    WorkingDirectory = Path.GetDirectoryName(@"\Chart.Graph\src\")
                }

            };

            process.Start();


        }
    }
}
