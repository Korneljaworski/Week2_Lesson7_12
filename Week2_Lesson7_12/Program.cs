public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
            Dane testowe : 4
            Rezultat w terminalu :
            Czwartek
        */

        Console.WriteLine("Podaj numer dnia tygodnia:");
        int dayOfWeek = Int32.Parse(Console.ReadLine());

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Poniedziałek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Środa");
                break;
            case 4:
                Console.WriteLine("Czwartek");
                break;
            case 5:
                Console.WriteLine("Piątek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Niedziela");
                break;
            default:
                Console.WriteLine("Błędny numer dnia!");
                break;
        }



    }

}