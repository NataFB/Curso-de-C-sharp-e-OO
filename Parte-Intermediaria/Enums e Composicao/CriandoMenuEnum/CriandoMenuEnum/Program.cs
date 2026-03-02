namespace CriandoMenuEnum
{

    class Program
    {
        // Definindo o enum Opcao com valores para o menu, Colocando 1 no primeiro item para facilitar a escolha pelo usuário, assim coemça com 1 e não com 0
        enum Option { Create = 1, Delete, Edit, List, Update}
        static void Main(string[] args)
        {
            Console.WriteLine("Select one option: ");
            Console.WriteLine("1-Create\n2-Delete\n3-Edit\n4-List\n5-Update");
            int userChoice = int.Parse(Console.ReadLine());
            Option selectedOption = (Option)userChoice;

            switch (selectedOption)
            {
                case Option.Create:
                    Console.WriteLine("Create option selected.");
                    break;
                case Option.Delete:
                    Console.WriteLine("Delete option selected.");
                    break;
                case Option.Edit:
                    Console.WriteLine("Edit option selected.");
                    break;
                case Option.List:
                    Console.WriteLine("List option selected.");
                    break;
                case Option.Update:
                    Console.WriteLine("Update option selected.");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}