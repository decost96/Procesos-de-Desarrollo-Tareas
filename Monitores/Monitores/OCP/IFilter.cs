using System;
using System.Collections.Generic;
using System.Text;

namespace Monitores
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
