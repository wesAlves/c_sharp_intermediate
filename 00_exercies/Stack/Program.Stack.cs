using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    internal partial class Program
    {
        public class Stack
        {
            private List<object> _stackObjects = new List<object> { };

            public void Push(object obj)
            {
                _stackObjects.Add(obj);
            }

            public object Pop()
            {
                return (object) _stackObjects.Last();
            }

            public void Clear()
            {
            }
        }
    }
}