// See https://aka.ms/new-console-template for more information
String arg1 = ShowCharacter("first statement");
     Char Letter = arg1[1-1];

double price = CalculateRetail(); 
double percent = CalculateRetail();


static string ShowCharacter(String answer)
    {
        Console.WriteLine("Please enter {0}",answer);
        return Console.ReadLine();
    }
        Console.WriteLine($"The letter is {Letter}");
    

static double CalculateRetail(double money)
    {
        Console.WriteLine("What is the {0}", money);
        return Console.ReadLine();
        double wholeDollar = ( price *  percent)/100;
        double total = wholeDollar + price;
        Console.WriteLine($"The retail price is {total}");
    }
)

 