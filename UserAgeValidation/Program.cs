Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, "13" - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}

else //if (userAge < 13) ;
{
    Console.WriteLine("You are too young to use Instagram. ");
}


