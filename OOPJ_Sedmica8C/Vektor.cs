namespace OOPJ_Sedmica8C
{
    internal class Vektor
    {
        public int X { get; set; } 
        public int Y { get; set; }

        public Vektor(int x, int y)
        {
            X = x;
            Y = y;
        }
        // (1,6)
        //(-1,-6)
        public static Vektor operator -(Vektor vektor)
        {
            return new Vektor(-vektor.X, -vektor.Y);
        }

        public static Vektor operator +(Vektor vektor)
        {
            return new Vektor(vektor.X, vektor.Y);
        }

        public static bool operator !(Vektor vektor)
        {
            return vektor.X == 0 && vektor.Y == 0;
        }
        //101010101
        //~
        //010101010
        //110
        //001
        //1010
        //0101
        public static Vektor operator ~(Vektor vektor)
        {
            return new Vektor(~vektor.X, ~vektor.Y);
        }

        public static Vektor operator ++(Vektor vektor)
        {
            return new Vektor(vektor.X + 1, vektor.Y+1);
        }
        public static Vektor operator --(Vektor vektor)
        {
            return new Vektor(vektor.X - 1, vektor.Y - 1);
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
