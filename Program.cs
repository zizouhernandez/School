using System;
using System.Collections.Generic;
using System.Threading;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista för byrån
           List<String> byra = new List<string>()
           {
           "Sten",
           "Fot",
           "Trosor",
           "Råtta",
           };
            //lägg ins aker i byrån, ska kunna ta ut saker, 
            // vad som finns i byrån
            // avsluta
            /*Utskrift till konsollen
        Inmatning av data, spara variabler i korrekt datatyp
         Selektion, if eller switch för meny
          Loop som accepterar menyval tills användaren väljer att avsluta programmet*/

           Console.WriteLine("Starting system");
           Thread.Sleep(800);
           Console.WriteLine("...");
           Console.WriteLine("Det här är din mögliga byrå. Vad vill du göra?");
           string menyval = "0";
           while (menyval != "5")
           {
           // skriver ut huvudmenyn
           Console.WriteLine("Välj ett alternativ:");
           Console.WriteLine("1. Lägg in ett föremål");
           Console.WriteLine("2. Ta ut föremål");
           Console.WriteLine("3. Läs upp vilka föremål det finns i byrån");
           Console.WriteLine("4. Rensa byrån");
           Console.WriteLine("5. Stäng byrån");
           menyval = Console.ReadLine();
           //tom rad innan användarens val körs
           Console.WriteLine(" ");

           // switchen
           switch (menyval)
           {
               case "1":
               Console.WriteLine("Vad vill du lägga in?");
               Console.WriteLine($"Det som redan finns i byrån är:");
               foreach (var list in byra)
               {
                   Console.WriteLine(list);
               }
               byra.Add(Console.ReadLine());
               break;

               case "2": 
               Console.WriteLine($"Det som finns i byrån är:");
               foreach (var list in byra)
               {
                   Console.WriteLine(list);
               }
               Console.WriteLine("Vad vill du ta ut?");
               byra.Remove(Console.ReadLine());
               break;

               case "3":
               Console.WriteLine($"Det som finns i byrån är:");
               foreach (var list in byra)
               {
                   Console.WriteLine(list);
               }
               break;

               case "4":
               Console.WriteLine("Rensa byrån");
               byra.Clear();
               Console.WriteLine("Allt är nu superduper clean!");
               break;

               case "5":
               Environment.Exit(-1);
               break;

               default:
               Console.WriteLine("Du valde inte ett giltigt alternativ");
               break;
           }
                 //Tom rad innan nästa körning
                Console.WriteLine("Tryck på valfri knapp för att komma till huvudmenyn igen");

                Console.ReadKey();
                Console.Clear();

        }
        }
    }
}
