using Matrix2dLib;

namespace Matrix2dTest
{
    [TestClass]
    public class Matrix2dTest
    {
        // Test sprawdza, czy konstruktor poprawnie inicjalizuje pola
        [TestMethod]
        public void Konstruktor_PowinienPoprawnieInicjalizowacPola()
        {
            //AA 

            // Arrange
            var expectedA = 2;
            var expectedB = 3;
            var expectedC = 4;
            var expectedD = 5;

            // Act
            var matrix = new Matrix2d(expectedA, expectedB, expectedC, expectedD);

            // Assert
            Assert.IsTrue(matrix.A == expectedA
                && matrix.B == expectedB
                && matrix.C == expectedC
                && matrix.D == expectedD);
        }
        // Test sprawdza, czy domyślny konstruktor ustawia macierz jednostkową
        [TestMethod]
        public void TestMacierzJednostkowa()
        {
            //AAA

            // Arrange
            var identity = Matrix2d.Id;
            // Act i Assert
            Assert.AreEqual(new Matrix2d(1, 0, 0, 1), identity);
        }

        // Test sprawdza, czy konstruktor bezparametrowy ustawia macierz jednostkową
        [TestMethod]
        public void TestMacierzZerowa()
        {
            var zero = Matrix2d.Zero;
            Assert.AreEqual(new Matrix2d(0, 0, 0, 0), zero);
        }

        // Test sprawdza, czy metoda ToString() zwraca poprawny format
        [TestMethod]
        public void ToString_PowinienZwracaćPoprawnyFormat()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(2, 3, 4, 5);
            var expectedString = "[[2, 3], [4, 5]]";

            // Act
            var result = matrix.ToString();

            // Assert
            Assert.AreEqual(expectedString, result);
        }

        // Test sprawdza, czy metoda Equals() zwraca Prawda dla równych macierzy
        [TestMethod]
        public void Equals_PowinienZwracaćTrueDlaRównychMacierzy()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 3, 4, 5);
            var matrix2 = new Matrix2d(2, 3, 4, 5);

            // Act
            var result = matrix1.Equals(matrix2);

            // Assert
            Assert.IsTrue(result);
        }

        // Test sprawdza, czy metoda Equals() zwraca Fałsz dla różnych macierzy
        [TestMethod]
        public void Equals_PowinienZwracacFalseDlaRóżnychMacierzy()
        {
            // AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 3, 4, 5);
            var matrix2 = new Matrix2d(5, 4, 3, 2);

            // Act
            var result = matrix1.Equals(matrix2);

            // Assert
            Assert.IsFalse(result);
        }

        // Test sprawdza, czy operator == zwraca Prawda dla równych macierzy
        [TestMethod]
        public void OperatorRówności_PowinienZwracaćTrueDlaRównychMacierzy()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 3, 4, 5);
            var matrix2 = new Matrix2d(2, 3, 4, 5);

            // Act
            var result = matrix1 == matrix2;

            // Assert
            Assert.IsTrue(result);
        }

        // Test sprawdza, czy operator != zwraca Prawda dla różnych macierzy
        [TestMethod]
        public void OperatorNierówności_PowinienZwracacTrueDlaRóznychMacierzy()
        {
            // AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 3, 4, 5);
            var matrix2 = new Matrix2d(5, 4, 3, 2);

            // Act
            var result = matrix1 != matrix2;

            // Assert
            Assert.IsTrue(result);
        }

        // Test sprawdza, czy metoda GetHashCode() zwraca ten sam hash code dla równych macierzy
        [TestMethod]
        public void GetHashCode_PowinienZwracaćTenSamHashCodeDlaRównychMacierzy()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 3, 4, 5);
            var matrix2 = new Matrix2d(2, 3, 4, 5);

            // Act
            var hashCode1 = matrix1.GetHashCode();
            var hashCode2 = matrix2.GetHashCode();

            // Assert
            Assert.AreEqual(hashCode1, hashCode2);
        }

        // Test sprawdza dodawanie macierzy
        [TestMethod]
        public void OperatorDodawania_PowinienZwracaćPoprawnaSume()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(2, 1, 0, 4);
            var matrix2 = new Matrix2d(5, 6, 7, 3);
            var expectedMatrix = new Matrix2d(7, 7, 7, 7);

            // Act
            var result = matrix1 + matrix2;

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        // Test sprawdza odejmowanie macierzy`
        [TestMethod]
        public void OperatorOdejmowania_PowinienZwracaćPoprawnaRóżnice()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(6, 7, 8, 9);
            var matrix2 = new Matrix2d(1, 2, 3, 4);
            var expectedMatrix = new Matrix2d(5, 5, 5, 5);

            // Act
            var result = matrix1 - matrix2;

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        // Test sprawdza mnożenie macierzy
        [TestMethod]
        public void OperatorMnozenia_PowinienZwracacPoprawnyIloczyn()
        {
            //AAA

            // Arrange
            var matrix1 = new Matrix2d(1, 2, 3, 4);
            var matrix2 = new Matrix2d(2, 0, 1, 2);
            var expectedMatrix = new Matrix2d(4, 4, 10, 8);

            // Act
            var result = matrix1 * matrix2;

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        // Test sprawdza mnożenie macierzy przez skalar
        [TestMethod]
        public void OperatorNegacji_PowinienZwracaćPoprawnąNegację()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(1, 2, 3, 4);
            var expectedMatrix = new Matrix2d(-1, -2, -3, -4);

            // Act
            var result = -matrix;

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        // Test sprawdza, czy metoda Transpose() zwraca poprawną transpozycję macierzy
        [TestMethod]
        public void Transpozycja_PowinnaZwracaćPoprawnąTranspozycję()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(1, 2, 3, 4);
            var expectedMatrix = new Matrix2d(1, 3, 2, 4);

            // Act
            var result = Matrix2d.Transpose(matrix);

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        // Test sprawdza, czy metoda Det() zwraca poprawny wyznacznik macierzy
        [TestMethod]
        public void Wyznacznik_PowinienZwracaćPoprawnyWyznacznik()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(1, 2, 3, 4);
            var expectedDeterminant = -2;

            // Act
            var result = matrix.Det();

            // Assert
            Assert.AreEqual(expectedDeterminant, result);
        }

        // Test sprawdza, czy metoda Determinant() zwraca poprawny wyznacznik macierzy
        [TestMethod]
        public void WyznacznikKlasy_PowinienZwracaćPoprawnyWyznacznik()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(1, 2, 3, 4);
            var expectedDeterminant = -2;

            // Act
            var result = Matrix2d.Determinant(matrix);

            // Assert
            Assert.AreEqual(expectedDeterminant, result);
        }

        // Test sprawdza, czy jawne rzutowanie na tablicę int[2,2] zwraca poprawną tablicę
        [TestMethod]
        public void JawneRzutowanieNaTablice_PowinnoZwracaćPoprawnąTablicę()
        {
            //AAA

            // Arrange
            var matrix = new Matrix2d(1, 2, 3, 4);
            var expectedArray = new int[,] { { 1, 2 }, { 3, 4 } };

            // Act
            var array = (int[,])matrix;

            // Assert
            CollectionAssert.AreEqual(expectedArray, array);
        }

        // Test sprawdza, czy metoda Parse() zwraca poprawną macierz
        [TestMethod]
        public void Parsowanie_PowinnoZwracaćPoprawnąMacierz()
        {
            // Arrange
            var input = "[[1, 2], [3, 4]]";
            var expectedMatrix = new Matrix2d(1, 2, 3, 4);

            // Act
            var result = Matrix2d.Parse(input);

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }


    }
}
