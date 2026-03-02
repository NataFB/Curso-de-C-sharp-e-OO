namespace ExtensionMethods
{
    public class ProcessFile
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2026, 2, 23, 8, 10, 45); // ano mes dia hora minutos e segundos
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}