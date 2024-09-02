using System;


namespace TwitterConsole
{
    class SystemGreatings
    {
        internal static void GreatingsClientDo()
        {

            string welcome = "Пожалуйста введите свое имя для авторизации:";
            Console.WriteLine(welcome);
            string GreatingsHandler = Console.ReadLine();

            if (GreatingsHandler.Equals("Дмитрий"))
            {

                Console.WriteLine("     .        .-:*:. ..");
                Console.WriteLine("    .**-     .********-.     ");
                Console.WriteLine("     :+***:-.:*******.       ");
                Console.WriteLine("    .****************.       ");
                Console.WriteLine("     .:************+-        ");
                Console.WriteLine("      .***********+-         ");
                Console.WriteLine("        .:******+*.          ");
                Console.WriteLine("    .:*++***+**-             ");
                Console.WriteLine("Добрый день {0}, добро пожаловать в Twitter. Посмотрите новые твиты:", GreatingsHandler);
            }
            else
            {
                Console.WriteLine("Пожалуйста введите свое имя для авторизации:");
            }


        }



    }
}
