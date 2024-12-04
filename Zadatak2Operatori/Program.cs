internal class Program
{
    public class Novac
    {
        public double Iznos { get; set; }
        public Novac(double Iznos) {
        this.Iznos = Iznos;
        }
        public static Novac operator +(Novac x, Novac y)
        {
            return new Novac(x.Iznos +y.Iznos);
        }

        public static Novac operator +(Novac x, int y)
        {
            return new Novac(x.Iznos + y);
        }
        public override string ToString()
        {
            return $"Iznos {Iznos}";
        }
    }
    private static void Main(string[] args)
    {
        //Napraviti klasu Novac koja ima atribut Iznos tipa double. Preklopite operator '+' za sabiranje dva objekta tipa Novac (sabirat ce iznos).
        //novac n1
        //novac n2
        // n1+n2 
        Novac n = new Novac(3);
        Novac n1 = new Novac(1);
        Console.WriteLine(n+5);
        Console.WriteLine(n + n1);
    }
}