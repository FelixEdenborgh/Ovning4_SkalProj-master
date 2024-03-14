using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool loopPlay = true;

            // loopar så länge loopPlay inte är falsk
            while (loopPlay)
            {
                Console.WriteLine("Enter +: To add, or -: To remove, S: To Show all data in list, c: to see what happens, q: to quit");
                Console.WriteLine("Like: +Adam to add Adam to list, or -Adam to remove Adam from list");
                string input = Console.ReadLine().ToLower();
                char nav = input[0];// get the command for + and -


                string value = input.Substring(1).ToLower(); // Checking list with start from secound value for example +Adam = Adam

                // Switch som hanterar menyn
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        for(int i = 0; i < theList.Count; i++)
                        {
                            if (theList[i] == value)
                            {
                                theList.RemoveAt(i);
                            }
                        }
                        break;
                    case 's':
                        foreach(var item in theList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 'q':
                        Console.WriteLine("Exiting ExamineList() method!");
                        loopPlay = false;
                        break;
                    case 'c':
                        Console.WriteLine(theList.Capacity);
                        Console.WriteLine(theList.Count);
                        break;
                    default:
                        Console.WriteLine("Only use '+' or '-' or 's' to show list, or 'q' to exit");
                        break;
                }
            }
            // Det jag kan se är att desså fler användare jag lägger till desså mer Process memeory används, och dessöt mer ökar Gc Heap Sizen,
            // samt att listan ökar storleken så fort man går upp till x antal, dvs 4 ökar till 8, 8 till 16 och 16 till 32. om jag lägger t ex in 4 namn så ökar listans kapasitet med dubbelt
            /*
             2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
                Listans kapacitet ökar varje gång man når den nuvarande kapaciteten, dvs är den 4 och man lägger till 4 namn så ökar den till dubbla.

            3. Med hur mycket ökar kapaciteten?
                Den ökar med dubbla. t ex 16 blir 32. Lite som binära räkne systemet, 0 1 2 4 8 16 32 64 128
             
            4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
                Jag tycker det ser ut att ha att göra med att den går efter det binära systemets räkne sätt och bara ökar om listans inerhåll innehåller nuvarande listans
                kapasitet dvs om listan är 4 så kan du bara lägga in 4 och inte 5, innan listan ökar till 8. Och att hade den ökat för varje element som lägs till så hade
                nog det tagit för mycket data och gjort projektet segare än att öka lite då och då.

            5. Minskar kapaciteten när element tas bort ur listan?
                Nej listans kapasitet krymper inte om det tas bort element från listan. Utan den förblir det som den var innan.

            6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
                Fast Storlek: Om man vet att det kommer bara vara en fast storlek av data som kommer behöva sparas och som inte kommer ändra sig så är arrays bäst.

                Prestanda: För små datamängder eller operationer som kräver direkt åtkomst via index kan arrays vara något snabbare än listor på grund av lägre overhead.

                Minnesanvändning: Arrays kan vara mer minneseffektiva särskilt för primitiva datatyper som (int, float etc) efter som de inte har den extra overhead som en lista har för att 
                hantera dynamisk storleksändring.

                Typsäkerhet och förutsägbarhet: Både arrays och listor i c# är typsäkra, kan användingen av en array ge en större känsla av förutsägbarhet gällande dess storlek
                och hur den hanteras i minnet, vilket kan vara fördelaktigt i vissa säkerhetskritiska eller hårt reltidssystem.
                
                Det är viktigt att komma ihåg att att även om det finns situationer där arrays kan vara mer lämpliga, så erbjuder listor en stor flexibilitet genom att tillåta
                dynamisk ändring av storlek, samt många hjälpmetoder för att lägga till, ta bort och söka element. 
                Valet mellan array eller listor beror helt på användningsfallets krav.
                
             */

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            //Skapar lista med que
            Queue<string> CustomerQue = new Queue<string>();

            // Loopen spelas så länge play inte är false
            bool play = true;
            while (play)
            {
                Console.WriteLine("1. Add person to que\n2. List all persons in que\n3. Remove a person from que\n4. Remove first person from que\n5. Show next one in top of que\n6. Exit\n");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Lägger till ny kund i listan
                        Console.WriteLine("Enter name of customer: ");
                        string customer = Console.ReadLine();
                        CustomerQue.Enqueue(customer);
                        Console.WriteLine();
                        break;
                    case "2":
                        // loopar igenom alla kunderna i listan
                        foreach(string cust in CustomerQue)
                        {
                            Console.WriteLine(cust);
                        }
                        break;
                    case "3":
                        // Att ta bort någon person som är mitten av listan bryter mot köns grundläggande princip först in och först ut (FIFO).
                        // Men det går att göra
                        // Med denna kan du både ta bort i mitten av listan samt första och sista. Du väljer själv
                        Console.WriteLine("Enter the name of the customer that are going to leave the Que: ");
                        string customerLeaveQue = Console.ReadLine().Trim(); // Tar bort oavsiktliga blanksteg

                        // För att ta bort någon i mitten av quelistan så behöver man göra en nya och sedan spara den nya över den gamla.
                        // Om man vill bara ta bort första eller sista så kan man köra "dequeue".
                        // Denna tar bara bort dem i mitten och inte första eller sista.
                        Queue<string> newQueList = new Queue<string>();
                        bool found = false;
                        foreach (string customersInQue in CustomerQue)
                        {
                            if (customersInQue.Equals(customerLeaveQue, StringComparison.OrdinalIgnoreCase) && !found)
                            {
                                found = true; // Förhindrar att fler kunder tas bort
                                continue; // Hoppar över att lägga till denna kund i den nya kön
                            }
                            // Lägger in alla andra kunder i den nya kön
                            newQueList.Enqueue(customersInQue);
                        }

                        if (found)
                        {
                            // Uppdaterar den ursprungliga kön endast om den specifika kunden hittades och togs bort
                            CustomerQue = newQueList;
                            Console.WriteLine($"{customerLeaveQue} has been removed from the que\n");
                        }
                        else
                        {
                            Console.WriteLine($"Person: {customerLeaveQue} was not found in the que\n");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Removing the first person in the que");
                        Console.WriteLine($"{CustomerQue.Peek()} has been removed from que\n");
                        CustomerQue.Dequeue();
                        break;
                    case "5":
                        // Vissar nästa kund som är på tur utan att ta bort den från kön.
                        if(CustomerQue.Count == 0)
                        {
                            Console.WriteLine("The list is empty\n");
                        }
                        else
                        {
                            string nextCustomer = CustomerQue.Peek();
                            Console.WriteLine($"\nNext customer thats gonna shop: {nextCustomer}");
                        }
                        break;
                    case "6":
                        // Avslutar loopen
                        Console.WriteLine("Loop ending!");
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Please only use the numbers: 1-6");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

