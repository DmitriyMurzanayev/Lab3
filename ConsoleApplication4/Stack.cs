using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Stack<T> : ClassVariable<T>
    {

        public Stack()
        {
            this._array = new T[defaultCapacity];
        }

        public Stack(int Capacity)
        {
            this._array = new T[Capacity];
        }

        public T Pop() //Удаляет и возвращает объект, находящийся в начале Stack.
        {
            if (this.size() == 0)
            { //вброс ошибки при взятии с пустого стека (Overflow)
                throw new InvalidOperationException();
            }
            return this._array[--index];
        }

        public void Push(T obj)
        {
            if (index == _array.Length) //если у нас переполнение
            {
                T[] tmp = _array;
                _array = null;
                _array = new T[2 * tmp.Length];
                for (int i = 0; i <= tmp.Length; i++)
                {
                    _array[i] = tmp[i];
                }
            }
            else if ((index * 3) >= _array.Length)
            {
                T[] tmp = _array;
                _array = new T[_array.Length / 2];
                _array = tmp;
            }
            _array[index] = obj;
            index++;
        }
    }
}
