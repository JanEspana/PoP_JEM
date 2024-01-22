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
    public class PopProject
    {
        public static void Main()
        {
            const string MSGINTRO = "Introdueix el dia, mes i any", MSGERROR = "El format no és correcte", MSGOK = "La data és correcta: {0}/{1}/{2}";
            int dia, mes, any;
            do
            {
                Console.WriteLine(MSGINTRO);
                dia = Convert.ToInt32(Console.ReadLine());
                mes = Convert.ToInt32(Console.ReadLine());
                any = Convert.ToInt32(Console.ReadLine());
                if (!Valida(dia, mes, any))
                {
                    Console.WriteLine(MSGERROR);
                }
            } while (!Valida(dia, mes, any));
            Console.WriteLine(MSGOK, dia, mes, any);
        }

        public static bool Valida(int day, int month, int year)
        {

            if (day < 1 || day > 31)

                return false;

            if (month < 1 || month > 12)

                return false;

            // determinem la quantitat de dies del mes:

            int totalDaysMonth = 0;

            switch (month)
            {

                case 1:

                case 3:

                case 5:

                case 7:

                case 8:

                case 10:

                case 12: totalDaysMonth = 31; break;

                case 4:

                case 6:

                case 9:

                case 11: totalDaysMonth = 30; break;

                case 2: // verifica l'any de traspàs

                    if (year % 4 == 0)
                    {
                        totalDaysMonth = 29;
                    }
                    else
                    {
                        totalDaysMonth = 28;
                    }
                    break;
            }

            if (day > totalDaysMonth)
            {
                return false;
            }
            return true;
        }
    }
}