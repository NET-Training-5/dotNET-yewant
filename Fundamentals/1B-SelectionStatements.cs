class Selection
{
    // Methods
    // Fields
    //int personAge = 23;             // Camel Casing
    public void LearnSelectionStatements() // Pascal casing
    {
        // Conditionals, Selection statements
        // If-else, if-elseif-else, switch
        // Branching

        Console.Write("Enter your age:");
        string ageText = Console.ReadLine();
        short age = short.Parse(ageText);

        if (age > 18) // >,<,<=, >=, !=, ==
        {
            Console.WriteLine("You are adult now.");
        }
        else
        {
            Console.WriteLine("You are still a child.");
        }

        // age < 18, Output should be "You are child"
        // age > 18 and age < 40, Output should be "You are adult"
        // age > 40 and age < 60, Output should be "You are in your middle age"
        // age > 60, Output should be "You are old now"
        
        if(age < 18)
        {
            Console.WriteLine("You are child");
        }
        else if(age < 40)
        {
            Console.WriteLine("You are adult");
        }
        else if(age < 60)
        {
            Console.WriteLine("You are in your middle age");
        }
        else
        {
            Console.WriteLine("You are old now");
        }

        // Mesh - "ka, kha"
        // Tula - "Ga gha"
        // Brisha - "Ba Bi"
        Console.Write("Enter your rashi:");
        string rashi = Console.ReadLine();

        if(rashi == "Mesh")
        {
            Console.WriteLine("Mesh rashi intials are ka, kha...");
        }
        else if(rashi == "Tula")
        {
            Console.WriteLine("Tula rashi intials are Ga, Gha...");
        }
        else
        {
            Console.WriteLine("Brisha rashi intials are ba, bi...");
        }

        switch(rashi)
        {
            case "Mesh": Console.WriteLine("Mesh rashi intials are ka, kha...");
            break;
            case "Tula": Console.WriteLine("Tula rashi intials are Ga, Gha...");
            break;
            case "Brisha": Console.WriteLine("Brisha rashi intials are ba, bi...");
            break;
            default:Console.WriteLine("Unknown rashi");
            break;
        }

    }
}