using System.Security.Cryptography.X509Certificates;

namespace Generics_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection box = new BoxCollection();
            box.Add(new Box(30, 12, 50));
            box.Add(new Box(30, 12, 50));
            box.Add(new Box(34, 22, 33));
            box.Add(new Box(20, 25, 47));
            box.Add(new Box(43, 17, 26));

            box.Display(box);

            Console.WriteLine("\n******************** Remove Box *********************\n");

            Box removeBox = new Box(43, 17, 26);
            box.Remove(removeBox);

            box.Display(box);

            Console.WriteLine("\n******************** Check if removed box is in the collection *********************\n");

            if (box.Contains(removeBox))
            {
                Console.WriteLine("Box Found!");
            }
            else
            {
                Console.WriteLine("Box Not Found");
            }

            Console.WriteLine("\n****************************** Contains ********************************\n");

            Box box5 = new Box(34, 22, 33);
            BoxSameDimensions dimChecker = new BoxSameDimensions();
            BoxSameVol volCheker = new BoxSameVol();

            bool boxContains = box.Contains(box5, dimChecker);
            Console.WriteLine(boxContains);


            Console.WriteLine("\n******************** Display Collection *********************\n");

            box.Display(box);


            Console.ReadKey();
        }
    }
}