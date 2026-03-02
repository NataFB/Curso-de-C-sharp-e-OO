using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
    // Generics: permite que classes, interfaces e métodos possam ser parametrizados por tipo.
    //por ser generic irá ser declarado o tipo específico depois assim podendo reutilizar com segurança(type safety) a classe para varios tipos.
    class PrintService <T> //Instanciando a classe generic com o <T>, que vai ser o tipo genérico da classe
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0]; 
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }



    }
}
