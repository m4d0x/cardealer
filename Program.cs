using System;
// 3.2 - Detta visar för programmet att vi vill använda oss utav grundläggande generiska klasser, som en lista.
using System.Collections.Generic;
namespace cardealer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. för att skapa menyalternativ (dvs stänga och starta specifika program) och ge möjlighet till loop och selektion har jag här skapat en bool med namn "sellCar"
            bool sellCar = false;

            // 2. Här nedan hämtas variablerna  för märke, modell, tillverkningsår, miltal & telefonnummer (för vidare kontakt mellan inköp och säljare)
            // 2.1 Denna string registrerar tillverkare/märke av fordonet
            string brand = "";

            // 2.2 Denna string registrerar bilmodell
            string model = "";

            // 2.3 Denna int får värdet från rad 56, som konverterats från rad 54. = Årtalet
            int year = 0;

            // 2.4 Denna int får värdet från rad 63, som konverterats från rad 61. = Miltalen
            int mileAge = 0;

            // 2.5 Denna int får värdet från rad 78, som konverterats från rad 76. = Priset
            int carPrice = 0;

            // 2.6 Denna int får värdet från rad .., som konverterats från rad ... = Telefonnummer för vidare kontakt mellan inköpare och säljare.
            int phoneNumber = 0;

            // 3.1 - För att kunna lista flera bilar som registreras av användaren så krävs ett annat bibliotek, detta är deklarerat på rad 3, under "using System;" (punkt 3.7.2)
            // 3.3 - "List<>" innebär att den är generisk - generisk innebär att den kan använda vilken variabeltyp som helst, dvs en lista med strängar, heltal, boolvariabler och doubles.
            // 3.4 - Genom att skriva in "string" skapar jag en "stränglista" och döper den till "allCars"
            // 3.5 -  med "=" dvs tilldelningsoperatorn för att säga att det är en ny stränglista
            List<string> allCars = new List<string>();

            // 3.6 Denna string vid namn bil är bara lokalt instansierad då listan innehåller 0 bilar från start, variablerna till bil som element blir deklarerade på rad 87. (SKA DETTA FLYTTAS UPP?)
            string bil = "";

            // 4.1 - Mitt do-while-påstående gör det möjligt att köra nedanstående rader med kod OM (if) svaret på programmets fråga nedan ÄR "sell"
            do
            {
                // 5.0 - Programmet öppnar med att välkomna användaren och ställer frågan om att köpa eller sälja fordon.
                Console.WriteLine("Välkommen! Vill du köpa eller sälja ett fordon? Skriv 'buy' eller 'sell' och tryck sedan Enter.");
                string answer = Console.ReadLine();

                // 6.1 - OM detta villkor stämmer och användaren svarar sell så kommer programmet nedan {inom if-statement} att köras - dvs programmet för registrering av fordon som användaren vill sälja.
                if (answer.Equals("sell"))
                {
                    // 6.1.1 - Programmet frågar om tillverkaren på fordonet.
                    Console.WriteLine("Vad spännande att du vill sälja din bil! Var god skriv in tillverkare och tryck sedan Enter:");

                    // 6.1.2 Svaret i konsolen sparas i stringens kodblock vid namn "brand" - rad 15.
                    brand = Console.ReadLine();

                    // 6.1.3 - Programmet frågar användaren om modell på fordonet.
                    Console.WriteLine("Okej, var god god skriv in model och tryck sedan Enter:");

                    // 6.1.4 - Svaret i konsolen sparas därefter i stringen "model" - rad 18.
                    model = Console.ReadLine();

                    // 6.1.5 - Programmet bekräftar med konkatenering av märket och modellen på fordonet och frågar därefter om miltal.
                    Console.WriteLine("Fordonet du vill sälja är en " + brand + " " + model + ", var god skriv årtalet bilen är tillverkad/utfärdad och tryck sedan Enter:");

                    // 6.1.6 - Då programmet kommer läsa in svaret som en sträng oavsett och jag vill att det ska initieras som en siffra - 
                    string stringYear = Console.ReadLine();

                    // 6.1.7 - Så behöver svaret i konsolen också konverteras och då försäkrar jag här att "stringYear" som sedan sparas i kodblocket int year ÄR en siffra.
                    year = Convert.ToInt32(stringYear);

                    // 6.1.8 - Konsollen frågar här hur långt användarens fordon har färdats, lika här så ska svaret registreras i talform och inte text
                    Console.WriteLine("Var god skriv hur långt din " + brand + " " + model + " av årsmodell " + year + " färdats i antal kilometer och tryck sedan Enter:");

                    // 6.1.9 - Därför blir svaret i konsolen en string vid namn "stringMileage"
                    string stringMileAge = Console.ReadLine();

                    // 6.1.10 - Och här konverteras "stringMileage" till ett tal och sparas i kodblocket "mileAge" och försäkrar programmet om att det ÄR en siffra.
                    mileAge = Convert.ToInt32(stringMileAge);

                    // 6.1.11 - Med hjälp av konkatenering så skriver programmet ut här den info som givits av användaren och ställer sedan frågan om användarens prisidé.
                    Console.WriteLine("Din " + brand + " " + model + ", tillverkad " + year + " har gått " + mileAge + " kilometer. Var god skriv er prisidé utan punkter eller komma-tecken och tryck sedan Enter:");

                    // 6.1.12 - här tas användarens prisidé upp och lagras i en sträng vid namn "stringCarPrice"
                    string stringCarPrice = Console.ReadLine();

                    // 6.1.13 - Här konverteras därefter stringen "stringCarPrice" till en int och lagras i variabeln "carPrice"
                    carPrice = Convert.ToInt32(stringCarPrice);

                    // 6.1.14 - Med hjälp av konkatenering så skriver programmet ut här den info som givits av användaren och ställer sedan motfråga om telefonnummer för vidare kontakt inför försäljning.
                    Console.WriteLine("Du vill sälja din " + brand + " " + model + ", tillverkad " + year + " som har gått " + mileAge + " kilometer. Vilket telefonnummer kan vi nå dig på för fortsatt kontakt? Skriv i nummer och avsluta med Enter:");

                    // 6.1.15 - här tas användarens telefonnummer upp och lagras i stärngen "stringPhoneNumber", detta kommer ej att skrivas ut då det enbart är till för inköparen och ej aktuellt i denna uppgift.
                    string stringPhoneNumber = Console.ReadLine();

                    // 6.1.16 - lika här konverteras strängen "stringPhoneNumber" till en int och lagras i variabeln "phoneNumber"
                    phoneNumber = Convert.ToInt32(stringPhoneNumber);

                    // 6.1.17 - För att bilen som ska säljas ska kunna listas måste bilen som "element" innefatta ett antal variabler när den listas och dessa innefattar nedanstående:
                    bil = "Tillverkare: " + brand + ", Modell: " + model + ", Årsmodell: " + year + ", Miltal: " + mileAge + " km, Pris: " + carPrice + " SEK";

                    // 6.1.18 - Elementet bil - sparas därefter till listan "allCars"
                    allCars.Add(bil);

                    // 6.1.19 (1.2) - Fortsatt om statement boolen "sellCar" har värdet true - VAD GÖR DENNA?????????????????????????????????????????????????????????????????????????????????????????????????????????????
                    sellCar = true;
                }
                // 6.2 - ANNARS OM vilkoret bemöts med "buy" på frågan om att köpa eller sälja fordon (rad 40) kommer {else if-statement} nedan att initieras.
                else if (answer.Equals("buy"))
                {
                    // 6.2.1 - Dvs. värdet för sellCar förändras till "false".
                    sellCar = false;
                }
            }
            // 4.2 - do-while innebär att SÅ LÄNGE svaret på frågan ovan är sell kommer bool variabeln ha värdet true och köra programmet i dennas {if-statement} tills svaret blir "buy" eller annat.
            while (sellCar == true);

            // 7.1 - foreach-loopen låter mig här skriva ut varje element som har sparats i listan "allCars", om inte användaren redan sparat element i listan kommer inget att listas.
            foreach (var Car in allCars)
            {
                // 7.1.1 - Programmet skriver därför ut alla element registrerade som "Car" i listan.
                Console.WriteLine(Car);
            }



        }
    }
}
