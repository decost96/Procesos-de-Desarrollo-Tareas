using System;
using System.Collections.Generic;
using System.Text;

namespace Monitores.OCP
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;
        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }
        public bool isSatisfied(ComputerMonitor item) => item.Type == _type;
    }
}
