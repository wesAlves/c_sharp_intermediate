using System;
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
                var poppedObj = _stackObjects.Last();
                _stackObjects.Remove(poppedObj);

                return poppedObj;
            }

            public void Clear()
            {
                while (_stackObjects.Count > 0)
                {
                    _stackObjects.Remove(_stackObjects.Last());
                }
            }

            public void PrintStack()
            {
                if (_stackObjects.Count > 0)
                {
                    foreach (var item in _stackObjects)
                    {
                        Console.WriteLine(item);
                    }
                }

                else
                {
                    Console.WriteLine("The stack is empty");
                }
            }
        }
    }
}