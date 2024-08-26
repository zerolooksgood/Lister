using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            int[] tall = { 1, 2, 3 }; //Definerer en array først istedenfor en list slik at jeg ikke trenger å skrive list.add() for hvert tall
            List<int> tallTemp = tall.ToList(); //Konverter arrayen til en list slik at det ikke er en lenge limit og jeg kan legge til flere tall
            tallTemp.Add(4); //legger til et fjerde tall til listen
            tall = tallTemp.ToArray(); //Konerterer tilbake til array for å spare plass
            Console.WriteLine(tall[0] + "" + tall[2]); //Printer første og tredje tall i listen (index 0 og 2 fordi 0 er det første tallet osv)

            //Oppg 2
            int[] tall2 = new int[2]; //ny array for å lagre resultatene av addisjonen og multipliseringen
            int temp1 = 0; //Tempvariabel
            for (int i = 0; i < tall.Length; i++) //Kjører for hvert element i listen
            {
                temp1 = temp1 + tall[i]; //Legger til tall nummer i (antall ganger loopen har kjørt) til temp variablen
            }
            tall2[0] = temp1; //Lagrer svaret til resultater arrayen
            Console.WriteLine(temp1); //Skriver ut alle tallene lagt sammen

            temp1 = 1; //Setter temp til 1 fordi jeg skal gange og man kan ikke gange med 0
            for (int i = 0; i < tall.Length; i++)
            {
                temp1 = temp1 * tall[i]; //Ganger alle tallene sammen
            }
            tall2[1] = temp1;
            Console.WriteLine(temp1); //Skriver ut produktet av alle tallene
            int[] combined = tall.Concat(tall2).ToArray(); //Kombinerer tall og tall2 til en array
            for (int i = 0; i < combined.Length; i++)
            {
                Console.WriteLine(combined[i]); //Skriver ut tallet i listen med index i
            }
            tallTemp = combined.ToList(); //Konverterer til list slik at jeg kan fjerne tall uten at det blir tomme spaces i listen
            tallTemp.RemoveAt(combined.Length - 1); //Fjerner det siste tallet
            tallTemp.RemoveAt(combined.Length - 2); //Fjerner det nest siste tallet
            combined = tallTemp.ToArray(); //Konverterer listen tilbake til array

            //Oppg 3
            string[] navn = new string[4]; //Lager en ny array med 4 plasser
            Console.WriteLine("Vennligst si 4 navn (a,b,c,d)"); //Spør om navn
            navn = Console.ReadLine().Split(','); //Splitter inputen ved "," slik at jeg får fire strings
            bool fantNavn = false;
            for (int i = 0;i < navn.Length;i++)
            {
                if (navn[i].ToLower() == "marius")
                {
                    fantNavn = true;
                }
            }
            //Oppg 4
            if (fantNavn == true)
            {
                Console.WriteLine("Du husker meg");
            } else
            {
                Console.WriteLine("Du har glemt meg");
            }

            Console.ReadLine(); //Holder programmet oppe
        }
    }
}
