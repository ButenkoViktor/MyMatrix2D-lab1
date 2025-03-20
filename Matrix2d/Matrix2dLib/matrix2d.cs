namespace Matrix2dLib
{
    public class Matrix2d
    {
        int a, b, c, d; // private fields
        /*
        -----
        |a b|
        |c d|
        -----
        */
        // Constructor
        public Matrix2d(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }
        // konstruktor bezparametrowy
        public Matrix2d() : this(1, 0, 0, 1) { }

        //publiczne stałe
        public static  Matrix2d Id
        {
            get { return new Matrix2d(); }
        }

        //macierz zerowa
        public static  Matrix2d Zero
        {
            get { return new Matrix2d(0, 0, 0, 0); }
        }

    }
}


