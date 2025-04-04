using System;
using System.IO;
using System.Media;
using System.Windows.Forms;


internal class Program
{
    static void Main()
    {
        // Display the ASCII logo
        DisplayAsciiLogo();

        Console.WriteLine("Loading chatbot...");

        // Play the welcome sound

        PlayGreeting();

        // Ask for the user's name
        Console.Write("\nEnter your name: ");
        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
        }

        // Display welcome message
        TypeText("\nWelcome to the Cybersecurity Awareness Bot!", 50);

        // Start the chatbot interaction loop
        while (true)
        {
            Console.Write("\nAsk me a cybersecurity question: ");
            string userQuestion = Console.ReadLine().ToLower();

            switch (userQuestion)
            {
                case "how are you?":
                    Console.WriteLine("I'm just a bot, but I'm here to help!");
                    break;
                case "what's your purpose?":
                    Console.WriteLine("I provide cybersecurity tips to keep you safe online.");
                    break;
                case "what can i ask you about?":
                    Console.WriteLine("You can ask about password safety, phishing, and safe browsing.");
                    break;
                default:
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                    break;
            }
        }
    }

    static void PlayGreeting()
    {
        try
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\RC_Student_lab\source\repos\S10444470.Peo_PART1\bin\Debug\Thutong Crescent (online-audio-converter.com).wav");
            soundPlayer.Play();
            soundPlayer.PlaySync();
            Console.WriteLine("Sound Finished playing .....");

           


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }

    static void DisplayAsciiLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
     ██████╗██╗   ██╗██████╗ ███████╗███████╗███████╗
    ██╔════╝██║   ██║██╔══██╗██╔════╝██╔════╝██╔════╝
    ██║     ██║   ██║██████╔╝███████╗█████╗  █████╗  
    ██║     ██║   ██║██╔═══╝ ╚════██║██╔══╝  ██╔══╝  
    ╚██████╗╚██████╔╝██║     ███████║███████╗███████╗
     ╚═════╝ ╚═════╝ ╚═╝     ╚══════╝╚══════╝╚══════╝
    ");
        Console.ResetColor();
    }

    static void TypeText(string text, int delay = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    static void DisplayHeader(string title)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n===============================");
        Console.WriteLine($"   {title.ToUpper()}   ");
        Console.WriteLine("===============================");
        Console.ResetColor();
    }
}
