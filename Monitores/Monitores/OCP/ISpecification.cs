using System;
using System.Collections.Generic;
using System.Text;

namespace Monitores
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
