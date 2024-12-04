internal class Program
{
    class MojaKlasa<T>
    {
        public MojaKlasa(T poruka)
        {
            Console.WriteLine(poruka);
        }
    }
    class Broj
    {
        public int Vrijednost { get; set; }
        public Broj(int br)
        {
            Vrijednost = br;
        }
        public override string ToString()
        {
            return $"{Vrijednost}";
        }
    }
    static void Zamijeni<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

    private static void Main(string[] args)
    {
        MojaKlasa<int> klasa1 = new MojaKlasa<int>(9);
        MojaKlasa<string> klasa2 = new MojaKlasa<string>("Hello world");
        Broj broj1 = new Broj(6);
        MojaKlasa<Broj> klasa3 = new MojaKlasa<Broj>(broj1);
        int a = 5;
        int b = 6;
        Console.WriteLine("Prije zamjene a:{0}, b:{1}", a, b);
        Zamijeni(ref a, ref b);
        Console.WriteLine("Poslije zamjene a:{0}, b:{1}", a, b);

        string a1 = "Laptop";
        string b1 = "Vrata";
        Console.WriteLine("Prije zamjene a:{0}, b:{1}", a1, b1);
        Zamijeni(ref a1, ref b1);
        Console.WriteLine("Poslije zamjene a:{0}, b:{1}", a1, b1);
        Broj a2 = new Broj(8);
        Broj b2 = new Broj(-6);
        Console.WriteLine("Prije zamjene a:{0}, b:{1}", a2, b2);
        Zamijeni(ref a2, ref b2);
        Console.WriteLine("Poslije zamjene a:{0}, b:{1}", a2, b2);
    }
}