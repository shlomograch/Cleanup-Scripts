using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChromeDriverProcessKiller
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.GetProcesses()
                .Where(x => x.ProcessName.ToLower()
                    .StartsWith("chrome"))
                .ToList()
                .ForEach(x => x.Kill());
        }
    }
}
