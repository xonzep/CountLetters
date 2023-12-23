namespace CountLetters;

public abstract class InputManager
{
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string? userInput = Console.ReadLine().ToLower();
        while (true)
        {
            bool isLetters = userInput.All(char.IsLetter);
            
            if (!isLetters || string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("That is not a word. Please type in a word.");
                userInput = Console.ReadLine().ToLower();
            }
            else
            {
                break;
            }
        }

        return userInput ?? throw new InvalidOperationException();
    }

    public static char GetTarget()
    {
        Console.WriteLine("Please input one letter that you would like to count.");
        string input = Console.ReadLine();
        bool isOneChar = false;
        
        while (!isOneChar )
        {
            if (input.All(char.IsLetter))
            {
                isOneChar = true;
            }
            else
            {
                Console.WriteLine("That is more than one letter or a number. Please input only one letter.");
                input = Console.ReadLine();
            }
        }

        char returnedInput = Convert.ToChar(input);
        return returnedInput;
    }
}