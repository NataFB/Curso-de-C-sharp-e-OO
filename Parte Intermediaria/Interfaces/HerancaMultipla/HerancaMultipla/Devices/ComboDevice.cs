using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultipla.Devices
{
    //O COMPILADOR NÃO AUTORIZA HERANÇA MULTIPLA, para isso vai ser usado Interfaces para que possar herdar mais de uma.
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice Print " + doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combodevice Processing " + doc);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
