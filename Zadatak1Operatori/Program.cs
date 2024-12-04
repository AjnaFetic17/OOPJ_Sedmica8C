namespace Zadatak1Operatori
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Napraviti klasu Broj koja ima jedan property Vrijednost tipa int. Preklopiti unarni operator '-' tako da negira vrijednost property-a.
            BrojMinus broj1 = new BrojMinus(5);
            BrojMinus broj2 = -broj1;
            Console.WriteLine(broj1);
            Console.WriteLine(broj2);
        }
    }
}