using Matrix2dLib;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<Matrix2D>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.ResetColor();

// Tworzenie macierzy jednostkowej
Console.WriteLine();
var matrixJedn = new Matrix2d();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Domyślna macierz (jednostkowa):");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(matrixJedn);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Tworzenie macierzy zerowej
var matrixZerowa = Matrix2d.Zero;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Macierz zerowa:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(matrixZerowa);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();


// Tworzenie niestandardowej macierzy
var matrixNiestandardowa = new Matrix2d(1, 2, 3, 4);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Niestandardowa macierz:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(matrixNiestandardowa);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();


// Dodawanie dwóch macierzy
var matrix2 = new Matrix2d(5, 6, 7, 8);
var suma = matrixNiestandardowa + matrix2;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 1: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{matrixNiestandardowa} ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 2: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrix2}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Suma macierzy:");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(suma);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor(); ;

// Odejmowanie dwóch macierzy
var roznica = matrix2 - matrixNiestandardowa;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 1: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{matrix2} ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 2: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrixNiestandardowa}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Różnica macierzy:");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(roznica);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Mnożenie dwóch macierzy
var mnorzenie = matrixNiestandardowa * matrix2;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 1: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{matrixNiestandardowa} ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz 2: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrix2}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mnożenie dwóch macierzy:");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(mnorzenie);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Mnożenie macierzy przez skalar
var mnorzenieSkalar = 2 * matrixNiestandardowa;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Skalar: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" [2] ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrixNiestandardowa}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Macierz pomnożona przez skalar 2:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(mnorzenieSkalar);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Transpozycja macierzy
var transpozycja = Matrix2d.Transpose(matrixNiestandardowa);
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrixNiestandardowa} ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Transpozycja macierzy:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(transpozycja);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Obliczanie wyznacznika
var wyznacznik = matrixNiestandardowa.Det();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{matrixNiestandardowa} ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Wyznacznik macierzy:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($" {wyznacznik}.");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Parsowanie macierzy ze stringa
var parsowanaMacierz = Matrix2d.Parse("[[9, 8], [7, 6]]");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Macierz: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{parsowanaMacierz} ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Parsowana macierz:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(parsowanaMacierz);
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<Koniec!>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.ResetColor();

