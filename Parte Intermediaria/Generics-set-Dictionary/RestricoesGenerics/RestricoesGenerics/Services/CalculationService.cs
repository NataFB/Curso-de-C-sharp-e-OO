using System;
using System.Collections.Generic;
using System.Text;

namespace RestricoesGenerics.Services
{
    class CalculationService
    {

        //Criando um método generic dentro de uma classe normal
        public T Max<T>(List<T> list) where T : IComparable // A lista tem que ser de um tipo T desde que esse tipo seja Icomparable( que tem um método de comparação: compareTo)
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++) 
            {
                //comparando usando a interface Icomparable
                if (list[i].CompareTo(max) > 0) // Icomparable retorna maior que zero quando o item é maior que o comparado
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
