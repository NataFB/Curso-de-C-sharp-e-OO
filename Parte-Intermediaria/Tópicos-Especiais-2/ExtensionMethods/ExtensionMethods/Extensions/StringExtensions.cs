

namespace System
{
    static class StringExtensions
    {
        // O primeiro parâmetro determina que o método é um método de extensão.
        // O primeiro parâmetro faz referência ao próprio objeto.
        public static string Cut(this string thisObj, int count)
        {
            if(thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
