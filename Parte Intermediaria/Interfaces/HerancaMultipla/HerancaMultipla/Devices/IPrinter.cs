namespace HerancaMultipla.Devices
{
    interface IPrinter
    {
        //Puxa apenas o método print e não o processDoc
        void Print(string doc);
    }
}
