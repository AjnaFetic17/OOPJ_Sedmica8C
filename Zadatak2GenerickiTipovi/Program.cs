internal class Program
{
    public interface IPohrani<T>
    {
        void Pohrani(T podatak);
        void Ispis();
    }

    public class Pohrana<T> : IPohrani<T>
    {
        private T podatak;
        public void Ispis()
        {
            Console.WriteLine(this.podatak);
        }

        public void Pohrani(T podatak)
        {
          this.podatak = podatak;
        }
    }

    private static void Main(string[] args)
    {
        //Napraviti genericki interfejs IPohrani<T> koji ce imati metodu za pohranu podataka i metodu za ispis tih podataka. Implementirati interfejs u klasi Pohrana <T> za tipove int i string. U glavnom programu pohraniti i ispisati podatke za oba tipa.
        Pohrana<int> pohrana1 = new Pohrana<int>();
        pohrana1.Pohrani(250);
        pohrana1.Ispis();

        Pohrana<string> pohrana2 = new Pohrana<string>();
        pohrana2.Pohrani("Neka poruka");
        pohrana2.Ispis();
    }
}