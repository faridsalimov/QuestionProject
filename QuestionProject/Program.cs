using static System.Formats.Asn1.AsnWriter;

namespace Question
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int score = 0, sual = 0;
            ConsoleKeyInfo key;
            string[,] questions = new string[10, 4]
            {
                {"Turkiyenin paytaxti haradir?", "Istanbul", "Ankara", "Adana"}, // 1
                {"Microsoft'un sahibi kimdir?", "Bill Gates", "Elon Musk", "John Cena"}, // 2
                {"128 + 87 = ?", "197", "252", "215" }, // 3
                {"Ilk telefon kim terefinden icad etmisdir?", "Martin Kuper", "Alexander Graham", "John Peirce"}, // 4
                {"Facebook'un sahibi kimdir?", "Mark Zuckerberg", "Sean Parker", "Joseph Murphy"}, // 5
                {"592 + 842 = ?", "1434", "1052", "1294"}, // 6
                {"Azerbaycanin ehalisi ne qederdir?", "9.000.000", "10.000.000", "14.000.000"}, // 7
                {"Python programlasdirma dili necenci ilde yaranib?", "1992", "1990", "1983"}, // 8
                {"C# programlasdirma dili necenci ilde yaranib?", "2000", "2006", "1990"}, // 9
                {"2 + 2 = ?", "4", "5", "6"}, // 10
            };

            #region Sual1
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();
            
            if (key.Key == ConsoleKey.B || key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual2
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual3
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.C || key.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual4
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.B || key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual5
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual6
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual7
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.B || key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual8
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.B || key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual9
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            #region Sual10
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[sual, 0]);
            Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score += 10;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(questions[sual, 0]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A) " + questions[sual, 1] + "\nB) " + questions[sual, 2] + "\nC) " + questions[sual, 3]);
                Thread.Sleep(2000);
                score -= 10;
            }
            sual++;
            #endregion

            if (score < 0)
                score = 0;

            Console.Clear();
            Console.WriteLine("Imtahan bitdi!\nXaliniz: " + score);
        }
    }
}