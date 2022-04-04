class Program 
{ 
        static void Main(string[] msg)
    {
        string Something = ShowCharacter("say something");
        string position = ShowCharacter("pick position of letter to display");
    
        int place = Convert.ToInt32(position);
        char home = Something[place-1];
         DisplayOutput(Something, position, home);


        double wholeSale = CalculateRetail("wholesale price");
        double markupPercent = CalculateRetail("markup percent ");
        double percent = markupPercent / 100;
        double price = percent * wholeSale;
        double retail = wholeSale + price; 

         DisplayOutput2(retail);
    
            double temp = 80;
            double temp2 = temp-32;
            double celcius = .56 * temp2;

        for(temp = 80, temp2 = temp -32, celcius = temp2 * .56; temp < 101; temp++,temp2++)
        { 
          
            Console.WriteLine($"Temperature conversion {temp} F is equal to {celcius} C");
        }

    }


    static string ShowCharacter(string msg)
    {
        Console.WriteLine("Please {0}",  msg);
        return Console.ReadLine();   
    }

    static double CalculateRetail(string msg)
        {
            Console. Write("what is {0}       ",msg);
            return double.Parse(Console.ReadLine());
        }

    
        static void DisplayOutput(string Something, string position, char home)
     {
         Console.WriteLine($"You said {Something} and asked to display {position} letter which is the letter {home}\n");
        
     }
        static void DisplayOutput2(double retail)
        {
            Console.WriteLine("The retail price is:        $ {0:f}\n", retail);
        }


 }