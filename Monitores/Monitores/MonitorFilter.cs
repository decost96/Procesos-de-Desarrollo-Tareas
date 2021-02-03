using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitores
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type) =>
                monitors.Where(m => m.Type == type).ToList();
    }
}
