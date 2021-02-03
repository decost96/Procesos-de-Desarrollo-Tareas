using System;
using System.Collections.Generic;
using System.Text;
using static Monitores.Program;

namespace Monitores
{
    public class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public Screen Screen { get; set; }
    }
}
