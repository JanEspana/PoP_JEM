using System;
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
            if (!valida(dia, mes, any))
            {
                Console.WriteLine(MSGERROR);
            }
        } while (!valida(dia, mes, any));
        Console.WriteLine(MSGOK, dia, mes, any);
    }

    public static bool valida(int day, int month, int year)
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