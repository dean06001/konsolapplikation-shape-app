using System;
namespace konsolapplikation_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appen kommer att beräkna arean och omkretsen av en rätvinklig triangel eller rektangel.");
            Console.WriteLine("Skriv bara talen när du anger höjd och bredd. Skriv inte ut måttenheterna");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Bestäm vilken figur du vill ha:");
                Console.WriteLine("Rätvinklig triangel");
                Console.WriteLine("Rektangel");
                Console.WriteLine();
                Console.Write("Svar: ");
                bool Svaret = int.TryParse(Console.ReadLine(), out int n);
                while (n > 2 || n < 1 || !Svaret)
                {
                    Console.WriteLine("Skriv 1 eller 2 för att välja.");
                    Console.WriteLine();
                    Console.Write("Svar: ");
                    Svaret = int.TryParse(Console.ReadLine(), out n);
                }
                Console.Clear();
                Console.WriteLine("Använd kommatecken \",\" om du vill skriva in decimaltal.");
                Console.WriteLine();
                Console.Write("Skriv höjd: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Skriv bredd: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        Console.WriteLine($"En triangel med höjden {height} och bredden {width} har en");
                        Triangle triangle = new Triangle(width, height);
                        Console.WriteLine($"Omkrets: {triangle.Circumference(width, height)}");
                        Console.WriteLine($"Area: {triangle.Area(width, height)}");
                        break;
                    case 2:
                        Console.WriteLine($"En rektangel med höjden {height} och bredden {width} har en");
                        Rectangle rectangle = new Rectangle(width, height);
                        Console.WriteLine($"Omkrets: {rectangle.Circumference(width, height)}");
                        Console.WriteLine($"Area: {rectangle.Area(width, height)}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}