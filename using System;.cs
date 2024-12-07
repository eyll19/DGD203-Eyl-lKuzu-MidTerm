using system ;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Game! Please enter your name:");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Hello, {playerName}! Let's begin the game.\n");

        // Step 2: Ask the series of questions
        int question1Answer = AskQuestion("Would you rather fight one horse-sized duck or 100 duck-sized horses?", new string[] { "A. One horse-sized duck", "B. 100 duck-sized horses" });
        int question2Answer = AskQuestion("Would you rather have the ability to fly or be invisible?", new string[] { "A. Fly", "B. Be invisible" });
        int question3Answer = AskQuestion("Would you rather always have the perfect amount of sleep or never have to eat?", new string[] { "A. Perfect sleep", "B. Never eat" });
        int question4Answer = AskQuestion("Would you rather be able to speak all human languages or communicate with animals?", new string[] { "A. Speak all languages", "B. Communicate with animals" });

        // Step 3: Generate a remark based on the answers
        Console.WriteLine("\nGame Summary:");
        if (question1Answer == 1 && question2Answer == 1)
        {
            Console.WriteLine($"{playerName}, you're a brave adventurer! You love challenges like fighting the impossible!");
        }
        else if (question3Answer == 1 && question4Answer == 1)
        {
            Console.WriteLine($"{playerName}, you're a creature of comfort and wisdom. You value the perfect life balance.");
        }
        else
        {
            Console.WriteLine($"{playerName}, you seem to be someone who likes to consider all options carefully!");
        }

        Console.WriteLine("Thanks for playing the game!");
    }

    static int AskQuestion(string question, string[] options)
    {
        Console.WriteLine(question);
        foreach (var option in options)
        {
            Console.WriteLine(option);
        }

        string answer = Console.ReadLine().ToUpper();
        while (answer != "A" && answer != "B")
        {
            Console.WriteLine("Invalid input. Please choose either 'A' or 'B'.");
            answer = Console.ReadLine().ToUpper();
        }

        return answer == "A" ? 1 : 2; // Return 1 for option A, 2 for option B
    }
}
