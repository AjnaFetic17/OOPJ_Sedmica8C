namespace OOPJ_Sedmica8C
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vektor v = new Vektor(1,6);
            string output = v.ToString();
            Console.WriteLine("Vektor: {0}", v);
            Console.WriteLine(output);
            Vektor v2 = -v;
            Console.WriteLine(v2);
            Vektor v3 = +v2;
            Console.WriteLine(v3);
            bool provjera = !v3;
            Console.WriteLine("Da li je vektor null: {0}", provjera);
            Vektor v4 = ~v;
            Console.WriteLine(v4);
            Vektor v5 = ++v4;
            Console.WriteLine(v5);
            Vektor v6 = --v;
            Console.WriteLine(v6);
        }
    }
}