


DoubleSecretPassword();
CountDown();
SecretPassword();
HenloFrend();
Environment.Exit(0);

static void HenloFrend()
{
    string answer = "y";
    do
    {
        Console.WriteLine("Henlo frend! \n");
        Console.WriteLine("Would you like to continue? <y> or <n>");
        answer = Console.ReadLine();
    } while (answer.ToLower() == "y");
}


static void CountDown()
{
    while (true)
    {
        Console.WriteLine("Enter a number bruh: ");
        int number;
        bool isValid = int.TryParse(Console.ReadLine(), out number);
        if (!isValid)
        {
            Console.WriteLine("Seriously dog, valid integers or gtfo!");
            continue;
        }

        for (int i = number; i >= 0; i--)
        {
            Console.Write(i + " ");

        }
        Console.WriteLine();
        for (int i = 0; i <= number; i++)
        {
            Console.Write(i + " ");

        }
        Console.WriteLine();

        Console.WriteLine("Would you like to continue? <y> or <n>");
        string answer = Console.ReadLine();
        if (answer != string.Empty && answer != null && answer.ToLower().Trim() == "y")
        {
            continue;
        }
        break;
    }
}

static void SecretPassword()
{
    bool isLocked = true;
    while (isLocked)
    {
        Console.WriteLine("Enter the secret password...");
        string answer = Console.ReadLine();
        if(!int.TryParse(answer, out int password))
        {
            Console.WriteLine("The password is a valid integer, sorry probably should have mentioned that...");
            continue;
        }
        if (password.ToString() == "13579")
        {
            Console.WriteLine("Welcome to the eyes wide shut party, lets get Tom Cruise...");
            isLocked = false;
        }
    }
}

static bool DoubleSecretPassword()
{
    bool isLocked = true;
    int count = 0;
    do
    {
        Console.WriteLine("Enter the secret password...");
        int password;
        bool isValid = int.TryParse(Console.ReadLine(), out password);
        if (!isValid)
        {
            Console.WriteLine("The password is a valid integer, sorry probably should have mentioned that...");
            count++;
            continue;
        }
        if (password.ToString() == "13579")
        {
            Console.WriteLine();
            isLocked = false;
            break;
        }
        count++;
    } while (count < 5);
    string message = isLocked ? "Best bounce, you have exceeded the maximum number of attempts guy!" : "Welcome to the eyes wide shut party, lets get Tom Cruise...";
    Console.WriteLine($"{message}");
    return !isLocked;
    
}



