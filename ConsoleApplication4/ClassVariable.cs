using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class ClassVariable<T>
    {
        protected T[] _array; //массив для хранения данных типа T
        protected const int defaultCapacity = 10; //вместимость
        public  int index = 0;

        public  int Count //параметр для вывода размера 
        {
            get
            {
                return this.size();
            }
        }
        //Просмотр элемента на вершине очереди.
        public virtual T Peek() 
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return _array[Count - 1];
        }
        //проверка на пустоту
        public bool isEmpty()
        { 
            return this.size() == 0;
        }
       
        //Возвращает элемент списка по индексу
        public T get(int i)
        {
            return (T)_array[i];
        }

         /*Возвращает количество элементов в списке*/
        public int size() {
           return index;
        }

        /*метод изменения размера.*/
        public void resize(int newlength) 
          {
           T[] newarray = new T[newlength];
           System.Array.Copy(_array, 0, newarray, 0, index);
           _array = newarray;
          }      
         };
 }

