using System;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Ryggsäcken
            // ## Steg 1

            // Ryggsäcken
            // I den här övningen ska du precis som i ovan övning hantera inmatning och utmatning. Programmet är en ryggsäck som styrs 
            // via menyn. 
            // Du ska kunna lägga till föremål i ryggsäcken, tex ett äpple. Du ska sedan kunna välja att skriva ut alla föremål.
            // Observera att du inte 
            // behöver jobba med array än (det kommer vi in på senare) utan det finns en simpel lösning till att lägga till fler föremål.
            // Du ska även 
            // kunna rensa ryggsäckens innehåll. Ett val för att avsluta programmet ska också finnas. För att lösa uppgiften behöver du 
            // använda dig av följande: 
         

            // •	Utskrift till konsollen
            // •	Inmatning av data, spara variabler i korrekt datatyp
            // •	Selektion, if eller switch för meny
            // •	Loop som accepterar menyval tills användaren väljer att avsluta programmet
            // •	Kodblock, tänk på att det är viktigt var du deklarerar dina variabler

            // ## Steg 2

            // Ryggsäcken – fortsättning
            // Du ska nu ersätta en del funktioner i den tidigare övningen Ryggsäcken som du gjorde tidigare. 
            // •	Gör en array där användaren kan mata in upp till 5 föremål
            // •	Utskriften av innehåller ska du nu skriva ut med en for-loop
            // •	Menyn ska vara skriver med en switch (om du inte redan gjort det).
            // •	Ditt program ska hantera felaktig inmatning så att du undviker att programmet kraschar.
            // Glöm inte att kommentera din kod och förklara dina val & hur det fungerar.
//-----------------------------------------------------------------------------------------------------------------------

            //Deklarerar en variabel som håller koll på antalet index som skall skapas.
            int qtyOfItems = 0;
            //Deklarerar en variabel som håller koll på vilket menyval som användaren vill göra.
            int userInput = 0;

            //do-while loop som kör sålänge användaren matat in fler än 6 eller mindre än 0 föremål i ryggsäckens index.
            
            do{
                //Try-Catch som fångar upp eventuella fel-inmatningar från användaren.
                try{
                        System.Console.WriteLine("Välkommen till ryggsäcken! Innan vi startar skall du få bestämma storleken på ryggsäcken.");
                        System.Console.WriteLine("Hur många föremål vill du lägga i din ryggsäck? Det får plats max 5 st.");
                        qtyOfItems = int.Parse(Console.ReadLine());

                    }catch(Exception e){
                    System.Console.WriteLine(e);
                    }

                    //If-sats som kontrollerar att användaren verkligen matar in max 5 men fler än -1 föremål till sin ryggsäck.
                    if(qtyOfItems > 5 || qtyOfItems < 0){
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Det får inte plats.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }    

                }while(qtyOfItems >5 || qtyOfItems <0);


                //Här skapas en vektor som läser av de index som användaren matade in, för att sedan kunna fylla på sin ryggsäck med x föremål.
                string [] addedItem = new string[qtyOfItems];

                //Do-while loop som körs sålänge den är sann.
            do{
                //Try-Catch som känner av så att användarens menyval är korrekt skrivet.
                //Meny för användaren.
                try{        
                    System.Console.WriteLine("[1] Lägga till ett föremål");
                    System.Console.WriteLine("[2] Rensa ryggsäcken");
                    System.Console.WriteLine("[3] Visa innehåll");
                    System.Console.WriteLine("[4] Avsluta spelet");
                    userInput = int.Parse(Console.ReadLine());
                    }catch(Exception e){
                        System.Console.WriteLine(e);
                    }
            
            

            
                // Switch-Case som känner av de val som användaren matat in och utför sedan ett case beroende på val.
                switch(userInput){

                case 1: 

                //For-loop som lägger till föremål på de index som angivits i början av programmet.
                for(int i = 0; i < addedItem.Length; i++)
                {
                    //Try-catch i en loop, för att avsluta programmet så lägger jag in en return; i catchen, annars fortsätter programmet att loopa.
                    try{
                            System.Console.Write("Lägg till något på plats "+ i + ": ");
                            addedItem[i] = Console.ReadLine();
                        }catch(Exception e){
                            System.Console.WriteLine(e);
                            return;
                        } 
                }
                    //För ögonens skull, console.clear.
                    Console.Clear();
                break;

                case 2: 
                        //raderar indexen
                        for (int i = 0; i < addedItem.Length; i++){
                            addedItem[i] = "";
                        }
                        System.Console.WriteLine("Innehållet är rensat!");
                break;

                case 3: 
                //for-loop som skriver ut de inmatade föremålen.
                    System.Console.WriteLine("Du har lagt till:");
                for (int i = 0; i < addedItem.Length; i++){
                        System.Console.WriteLine(addedItem[i]);
                }

                break;

                case 4: 
                //Avslutar programmet
                    System.Console.WriteLine("Programmet avslutas, tack för att du spelade.");
                return;

                default:
                //på övrigt inmatade nummer. Default.
                    System.Console.WriteLine("Felaktig inmatning.");

                break; 
                 
            }
            }while (true);
       
        }
    }
}
