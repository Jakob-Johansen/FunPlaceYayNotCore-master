using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInputNumber;
            int ballonQuantity;

            Console.Write("Vælg et antal balloner: ");
            UserInputNumber = Convert.ToInt32(Console.ReadLine());

            ballonQuantity = UserInputNumber;

            // Laver et array som er en instans/forkomst af klassen Ballon.
            Ballon[] balloneArray = new Ballon[ballonQuantity];

            // Laver et objekt som er en instans/forkomst af Color klassen.
            Color color = new Color(255, 255, 255);

            Random random = new Random();

            for (int i = 0; i < ballonQuantity; i++)
            {
                // Laver et objekt som er en instans af Klassen ballon, hvor size er random tilføjet og color er 5.
                Ballon ballon = new Ballon(random.Next(1, 11), color);

                // Her tilføjer vi ballon som indeholder en random størrelse og farven 5, til vores array.
                balloneArray[i] = ballon;
            }

            for (int i = 0; i < balloneArray.Length; i++)
            {
                // laver en int som indeholder et random tal imellem 1 til 11
                int randomActiveNumber = random.Next(1, 11);

                var item = balloneArray[i];

                if (item.GetSize() == randomActiveNumber)
                {
                    item.Pop();
                }
                else
                {
                    item.Throw();
                }
            }

            for (int i = 0; i < balloneArray.Length; i++)
            {
                Console.WriteLine(balloneArray[i].ThrownQuantity());
            }

            Console.ReadLine();
        }
    }
}
