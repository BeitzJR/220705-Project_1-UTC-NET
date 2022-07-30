using Actions;

namespace RPG_P1
{

    class Program
    {

        static void Main()
        {

            Console.Clear();
            string textToEnter = "Welcome to the Border of many Lands";
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            textToEnter = "Press a key to continue";

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.ReadKey();

            Actions.Menu gameStart = new Actions.Menu();

        }

    }


}



