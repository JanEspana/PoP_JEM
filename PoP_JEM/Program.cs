using System;
namespace PoP_JEM
{
    class Ex2
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            const string MENU = "Escull una opció:\nA. Saltar\nB. Córrer\nC. Ajupir-se\nD. Amagar-se", ERROR = "Opció incorrecta",
                JUMP = "Salt", RUN = "Corre", SHIFT = "S'ajup", D = "S'amaga";
            char option;
            do
            {
                Console.WriteLine(MENU);
                option = Convert.ToChar(Console.ReadLine());
                if (option == 'A' || option == 'a')
                {
                    Console.WriteLine(JUMP);
                    repeat = false;
                }
                else if (option == 'B' || option == 'b')
                {
                    Console.WriteLine(RUN);
                    repeat = false;
                }
                else if (option == 'C' || option == 'c')
                {
                    Console.WriteLine(SHIFT);
                    repeat = false;
                }
                else if (option == 'D' || option == 'd')
                {
                    Console.WriteLine(D);
                    repeat = false;
                }
                else
                {
                    Console.WriteLine(ERROR);
                    repeat = true;
                }
            } while (repeat);
        }
    }
}