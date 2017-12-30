using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ArrayList<T> : ClassVariable<T>
    {
        public ArrayList()
        {
            this._array = new T[defaultCapacity];
        }

        public ArrayList(int Capacity)
        {
            this._array = new T[Capacity];
        }

        public void Add(T item) //Добавляет новый элемент в список.
        {
            if (index == _array.Length - 1)
                resize(_array.Length * 2);
            _array[index++] = item;
        }

        public void Remove(int i)
        {
            for (int j = i; j < index; j++)
            {
                _array[j] = _array[j + 1];
                _array[index] = default(T);
                index--;
            }
            if (_array.Length > defaultCapacity && index < _array.Length / 2)
                resize(_array.Length / 2); // если элементов в CUT_RATE раз меньше чем длина массива, то уменьшим в два раза
        }
    }
}
