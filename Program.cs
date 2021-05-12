using System;
// Importerar klassbibliotik för att kunna använda listor.
using System.Collections.Generic;
namespace cardealer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool för att loopa igenom programmet, om användaren vill sälja en bil så körs det om annars skrivs listan som bilhandlaren har att sälja ut
            bool sellCar = false;

            // Här deklareras variablerna  för märke, modell, tillverkningsår, miltal ( och telefonnummer för vidare kontakt mellan inköp och säljare)
            
            // Deklarerar ens sträng-variabel för märke/tillverkare.
            string brand = "";

            // Deklarerar en sträng-variabel för modellen.
            string model = "";

            // Deklarerar en int-variabel för årtal.
            int year = 0;

            // Deklarerar en int-variabel för miltalen.
            int mileAge = 0;

            // Deklarerar en int-variabel för priset på bilen.
            int carPrice = 0;

            // Deklarerar en int-variabel för att spara telefonnummer (enbart för bilhandlaren).
            int phoneNumber = 0;

            // För att göra programmet modulärt och slippa flera olika variabler, det skapar möjlighet att lägga till så många bilar som användaren vill.
            List<string> allCars = new List<string>();

            // Deklarer en sträng-variabel för bil för att spara allting om bilen.
            string bil = "";



            // Gör det möjligt att köra nedanstående rader kod OM (if) svaret är "sell".
            do
            {
                // Programmet öppnar med att välkomna användaren och ställer frågan om att köpa eller sälja fordon.
                Console.WriteLine("Välkommen! Vill du köpa eller sälja ett fordon? Skriv 'buy' eller 'sell' och tryck sedan Enter.");
                string answer = Console.ReadLine();

                // Om svaret är sell får användaren ge input om bilen de vill sälja.
                if (answer.Equals("sell"))
                {
                    // Programmet frågar om tillverkaren på fordonet.
                    Console.WriteLine("Vad spännande att du vill sälja din bil! Var god skriv in tillverkare och tryck sedan Enter:");

                    // Sparar användarens input i brand.
                    brand = Console.ReadLine();

                    // Programmet frågar användaren om modell på fordonet.
                    Console.WriteLine("Okej, var god god skriv in model och tryck sedan Enter:");

                    // Sparar användarens input i model - rad 18.
                    model = Console.ReadLine();

                    // Konkatinerar ihop strängarna nedanför med brand och model och skrivs ut i konsolen.
                    Console.WriteLine("Fordonet du vill sälja är en " + brand + " " + model + ", var god skriv årtalet bilen är tillverkad/utfärdad och tryck sedan Enter:");

                    // Användarens input tas upp och konverteras till int och sparas i year.
                    year = Convert.ToInt32(Console.ReadLine());

                    // Programmet konkatinerar ihop strängar och brand,model samt year och ställer frågan om miltal.
                    Console.WriteLine("Var god skriv hur långt din " + brand + " " + model + " av årsmodell " + year + " färdats i antal kilometer och tryck sedan Enter:");

                    // Användarens input konverteras till en int och sparas i mileAge.
                    mileAge = Convert.ToInt32(Console.ReadLine());

                    // Programmet konkatinerar strängar, brand, model, year och mileAge och ber därefter om användarens "prisidé".
                    Console.WriteLine("Din " + brand + " " + model + ", tillverkad " + year + " har gått " + mileAge + " kilometer. Var god skriv er prisidé utan punkter eller komma-tecken och tryck sedan Enter:");

                    // Användarens input konverteras till en int och sparas i carPrice.
                    carPrice = Convert.ToInt32(Console.ReadLine());

                    // Konkatinering av strängar, brand, model, year, mileAge och ber sedan om telefonnummer.
                    Console.WriteLine("Du vill sälja din " + brand + " " + model + ", tillverkad " + year + " som har gått " + mileAge + " kilometer. Vilket telefonnummer kan vi nå dig på för fortsatt kontakt? Skriv i nummer och avsluta med Enter:");

                    // Användarens input konverteras till int och sparas i phoneNumber (skrivs EJ ut.)
                    phoneNumber = Convert.ToInt32(Console.ReadLine());

                    // Sparar ner all informationen i bil-variabeln.
                    bil = "Tillverkare: " + brand + ", Modell: " + model + ", Årsmodell: " + year + ", Miltal: " + mileAge + " km, Pris: " + carPrice + " SEK";

                    // Lägger till informationen om bilen i listan.
                    allCars.Add(bil);

                    // Sätter boolen sellCar till true för att loopen ska köras igen.
                    sellCar = true;
                }
                // Om villkoret är köpa sätts variabeln sellCar till false och loopen kommer inte köras igen och alla bilar skrivs ut.
                else if (answer.Equals("buy"))
                {
                    sellCar = false;
                }
            }
            // Loopen körs medan sellCar är true.
            while (sellCar == true);

            // Går igenom alla elemnt i allCars-listan och skriver ut i konsolen.
            foreach (var Car in allCars)
            {    
                Console.WriteLine(Car);
            }



        }
    }
}
