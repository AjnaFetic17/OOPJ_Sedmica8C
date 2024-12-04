internal class Program
{
    public class Kutija<T>
    {
        private T sadrzaj;

        public Kutija(T sadrzaj)
        {
            this.sadrzaj = sadrzaj;
        }
        public T GetValue()
        {        
            return sadrzaj; 
        }
    }
    private static void Main(string[] args)
    {
        //Napraviti genericku klasu Kutija<T> koja moze pohraniti bilo koji tip podatka i omoguciti dohvacanje tog podatka.
        //Klasa treba sadrzavati privatnu varijablu tipa T i metodu za dohvacanje tog podatka.
        //testirati sa int i string tipovima
        Kutija<int> kutija = new Kutija<int>(5);
        Console.WriteLine("Sadrzaj kutije: {0}", kutija.GetValue());
        Kutija<string> kutija2 = new Kutija<string>("Pozdrav");
        Console.WriteLine("Sadrzaj kutije: {0}", kutija2.GetValue());
    }
}