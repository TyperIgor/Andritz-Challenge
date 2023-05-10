using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Graph
{
    public interface ILink<T>
    {
        T Source { get; }
        T Target { get; }
    }

    public class Link<T> : ILink<T>
    {
        public Link(T source, T target)
        {
            Source = source;
            Target = target;
        }

        public T Source { get; private set; }
        public T Target { get; private set; }

        public override string ToString()
        {
            return $"{Source?.ToString()} -> {Target?.ToString()}";
        }
    }
}
