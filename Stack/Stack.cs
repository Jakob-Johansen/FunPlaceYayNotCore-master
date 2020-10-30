using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private List<object> _objectList = new List<object>();
        private string _emptyStack = "Stack is empty";

        public Stack() { }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot be null.");

            _objectList.Add(obj);
        }

        public object Pop()
        {
            if (_objectList.Count == 0)
                throw new InvalidOperationException(_emptyStack);

            var index = _objectList.Count - 1;

            object thisObject = _objectList[index];
            _objectList.RemoveAt(index);
            return thisObject;
        }

        public void Clear()
        {
            if (_objectList.Count == 0)
                throw new InvalidOperationException(_emptyStack);

            _objectList.Clear();
        }
    }
}
