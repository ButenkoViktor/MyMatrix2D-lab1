#nullable disable
namespace Matrix2dLib
{
    public class Matrix2d : IEquatable<Matrix2d>
    {
        int a, b, c, d; // private fields

        // Public properties to expose private fields
        public int A => a;
        public int B => b;
        public int C => c;
        public int D => d;
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
        public static Matrix2d Id
        {
            get { return new Matrix2d(); }
        }

        //macierz zerowa
        public static Matrix2d Zero
        {
            get { return new Matrix2d(0, 0, 0, 0); }
        }

        // Przesłonięcie metody ToString()
        public override string ToString()
        {
            return $"[[{a}, {b}], [{c}, {d}]]";
        }

        // Przesłonięcie metody Equals()
        public override bool Equals(object obj)
        {
            return Equals(obj as Matrix2d);
        }
        public bool Equals(Matrix2d other)
        {
            if (other is null)
                return false;

            return a == other.a &&
                b == other.b &&
                c == other.c &&
                d == other.d;
        }

        // Przeciążenie operatora ==
        public static bool operator ==(Matrix2d left, Matrix2d right)
            => left.Equals(right);

        // Przeciążenie operatora !=
        public static bool operator !=(Matrix2d left, Matrix2d right)
            => !(left == right);
        // Przesłonięcie metody GetHashCode()
        public override int GetHashCode()
           => HashCode.Combine(a, b, c, d);


        // dodawanie macierzy
        public static Matrix2d operator +(Matrix2d left, Matrix2d right)
            => new Matrix2d(left.a + right.a, left.b + right.b,
                            left.c + right.c, left.d + right.d);


        // odejmowanie macierzy
        public static Matrix2d operator -(Matrix2d left, Matrix2d right)
           => new Matrix2d(left.a - right.a, left.b - right.b,
                           left.c - right.c, left.d - right.d);


        // mnożenie macierzy
        public static Matrix2d operator *(Matrix2d left, Matrix2d right)
            => new Matrix2d(
                left.a * right.a + left.b * right.c,
                left.a * right.b + left.b * right.d,
                left.c * right.a + left.d * right.c,
                left.c * right.b + left.d * right.d);


        // mnożenie macierzy przez liczbę 
        public static Matrix2d operator *(int k, Matrix2d macierz)
            => new Matrix2d(k * macierz.a, k * macierz.b,
                            k * macierz.c, k * macierz.d);

        public static Matrix2d operator *(Matrix2d macierz, int k)
           => k * macierz;

        // jednoargumentowy operator zmiany znaku
        public static Matrix2d operator -(Matrix2d macierz)
            => new Matrix2d(-macierz.a, -macierz.b,
                            -macierz.c, -macierz.d);
        // operację transpozycji macierzy 
        public static Matrix2d Transpose(Matrix2d m)
            => new Matrix2d(m.a, m.c, m.b, m.d);

        // Metoda obliczająca wyznacznik macierzy
        public int Det()
            => a * d - b * c;

        // Metoda klasy obliczająca wyznacznik macierzy
        public static int Determinant(Matrix2d matrix)
            => matrix.a * matrix.d - matrix.b * matrix.c;

        // Operator jawnego rzutowania na tablicę int[2,2]
        public static explicit operator int[,](Matrix2d matrix)
            => new int[,] { { matrix.a, matrix.b }, { matrix.c, matrix.d } };

        public static Matrix2d Parse(string input)
        {
            try
            {
                // Usunięcie białych znaków
                input = input.Replace(" ", "");

                // Sprawdzenie formatu
                if (!input.StartsWith("[[") || !input.EndsWith("]]"))
                    throw new FormatException("Nieprawidłowy format");

                // Usunięcie nawiasów z początku i końca
                input = input.Substring(2, input.Length - 4);

                // Podział na wiersze
                var rows = input.Split("],[");

                if (rows.Length != 2)
                    throw new FormatException("Nieprawidłowy format");

                // Podział na elementy
                var row1 = rows[0].Split(',');
                var row2 = rows[1].Split(',');

                if (row1.Length != 2 || row2.Length != 2)
                    throw new FormatException("Nieprawidłowy format");

                
                int a = int.Parse(row1[0]);
                int b = int.Parse(row1[1]);
                int c = int.Parse(row2[0]);
                int d = int.Parse(row2[1]);

                return new Matrix2d(a, b, c, d);
            }
            catch (Exception ex)
            {
                throw new FormatException("Nieprawidłowy format", ex);
            }
        }
    }
}


