using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCodeEquals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }


        // Sobrescrevendo com a nova lógica de comparação para a classe utilizando Equals
        public override bool Equals(object? obj)
        {
            if(!(obj is Client client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }


        // Sobrescrevendo o hashcode para ser gerado com base no email assim se tiver o mesmo email o hashcode é igual
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
