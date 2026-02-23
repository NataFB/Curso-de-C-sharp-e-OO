namespace HerancaMultipla.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing" + doc);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}