Console.WriteLine("Please enter your name. ");
string name = Console.ReadLine();
string checktocontinue = "yes";
string front = "";
string back = "";
while(checktocontinue == "yes") 
{
    Console.WriteLine("Hello, " + name + ". Please enter an integer from 1 to 100 inclusive. ");
    double userinput = double.Parse(Console.ReadLine());

    if(userinput % 1 != 0 || userinput < 1 || userinput > 100)
    {
        Console.WriteLine(name+", that isn't an integer from 1 to 100 inclusive.");
        
    }
    else if(userinput % 2 == 0 && userinput % 1 == 0 && userinput > 1 && userinput < 100)
    {
        front = "Even and ";
        if(userinput < 25)
        {
             back = "less than 25.";
        }
        else if(userinput >= 26 && userinput <= 60)
        {
            back = "between 26 and 60 inclusive.";
        }
        else
        {
            back = "greater than 60.";
        }
    }
    else if(userinput % 2 != 0 && userinput % 1 == 0 && userinput > 1 && userinput < 100)
    {
        front = "Odd and ";
        if(userinput < 60)
        {
            back = "less than 60.";
        }
        else
        {
            back = "greater than 60.";
        }
    }
    Console.WriteLine(front+back);
    Console.WriteLine(name+", would you like to analyze another number? Yes or No.");
    checktocontinue = Console.ReadLine().ToLower();
}


