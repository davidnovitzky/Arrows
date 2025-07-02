Arrow arrow = new(ChooseArrowHeadType(), ChooseFletchingType(), ChooseShaftLength());

DisplayArrowMenu();
DisplayArrowSummary();

MaterialType ChooseArrowHeadType()
{
    while (true)
    {
        Console.Write("Pick an arrowhead type (Steel, Wood, Obsidian): ");
        string arrowheadInput = Console.ReadLine().ToLower().Trim();

        switch (arrowheadInput)
        {
            case "steel":
                {
                    return MaterialType.Steel;
                }
            case "wood":
                {
                    return MaterialType.Wood;
                }
            case "obsidian":
                {
                    return MaterialType.Obsidian;
                }
            default:
                {
                    Console.WriteLine("Invalid Arrow Head Type");
                    break;
                }
        }
    }
}
MaterialType ChooseFletchingType()
{
    while (true)
    {
        Console.Write("Pick a Fletching type (Plastic, Turkey Feathers, Goose Feathers): ");
        string fletchingTypeInput = Console.ReadLine().ToLower().Trim();

        switch (fletchingTypeInput)
        {
            case "plastic":
                {
                    return MaterialType.Plastic;
                }
            case "turkey feathers":
                {
                    return MaterialType.TurkeyFeathers;
                }
            case "goose feathers":
                {
                    return MaterialType.GooseFeathers;
                }
            default:
                {
                    Console.WriteLine("Invalid Fletching Type");
                    break;
                }
        }
    }
}
float ChooseShaftLength()
{
    float shaftLengthInput = 0;

    while (shaftLengthInput < 60 || shaftLengthInput > 100)
    {
        Console.Write("Pick a length for your shaft (60cm-100cm): ");
        shaftLengthInput = float.Parse(Console.ReadLine());
    }
    return shaftLengthInput;
}
void DisplayArrowSummary()
{
    Console.WriteLine($"You picked a {arrow.Arrowhead} arrowhead type");
    Console.WriteLine($"You picked a {arrow.Fletching} fletching type");
    Console.WriteLine($"Your shaft length is {arrow.Length} cm long");
    Console.WriteLine($"The arrow costs {arrow.GetCost()} gold.");
}
void DisplayArrowMenu()
{
    while (true)
    {
        Console.WriteLine("Choose an arrow type:");
        Console.WriteLine("1. Elite Arrow");
        Console.WriteLine("2. Beginner Arrow");
        Console.WriteLine("3. Marksman Arrow");
        Console.WriteLine("4. Custom Arrow");
        Console.Write("Enter the number of your choice: ");

        string menuChoice = Console.ReadLine();

        switch (menuChoice)
        {
            case "1":
                arrow = Arrow.CreateEliteArrow(); // has to be static for it to be a class method
                break;
            case "2":
                arrow = Arrow.CreateBeginnerArrow(); // instance methods require objects
                break;
            case "3":
                arrow = Arrow.CreateMarksmanArrow();
                break;
            case "4":
                arrow = new Arrow(ChooseArrowHeadType(), ChooseFletchingType(), ChooseShaftLength());
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                continue;
        }
        break;
    }
}
