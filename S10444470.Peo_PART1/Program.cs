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
        Console.ForegroundColor = ConsoleColor.Cyan;
        
        TypeText($"\nWelcome {userName} to the Cybersecurity Awareness Bot!", 50);
        Console.ResetColor();

        // Start the chatbot interaction loop
        while (true)
        {
            Console.Write("\nAsk me a cybersecurity question: ");
            string userQuestion = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(userQuestion))
            {
                Console.WriteLine("Please enter a valid question.");
                continue;
            }

            switch (userQuestion)
            {
                case "how are you?":
                    Console.WriteLine("I'm just a bot, but I'm here to help keep you safe online!");
                    break;

                case "what's your purpose?":
                    Console.WriteLine("My purpose is to provide cybersecurity tips to keep you safe from online threats.");
                    break;

                case "what can i ask you about?":
                    Console.WriteLine("You can ask about:");
                    Console.WriteLine("- Password Safety");
                    Console.WriteLine("- Phishing Scams");
                    Console.WriteLine("- Safe Browsing");
                    Console.WriteLine("- Malware Protection");
                    Console.WriteLine("- Public Wi-Fi Risks");
                    Console.WriteLine("- General Cybersecurity Tips");
                    break;

                // Phishing Related Questions
                case "what is phishing?":
                    Console.WriteLine("Phishing is a cyberattack where scammers trick you into revealing personal information by pretending to be a trusted entity.");
                    Console.WriteLine("Always verify links before clicking and never share sensitive information over email.");
                    break;

                case "how do i stay safe from phishing?":
                    Console.WriteLine("To stay safe from phishing:");
                    Console.WriteLine("- Don't click on suspicious links.");
                    Console.WriteLine("- Verify the sender of emails and messages.");
                    Console.WriteLine("- Use multi-factor authentication (MFA).");
                    break;

                // Safe Browsing
                case "what is safe browsing?":
                    Console.WriteLine("Safe browsing means using the internet securely by avoiding malicious websites and scams.");
                    Console.WriteLine("Always use secure connections (HTTPS) and keep your software updated.");
                    break;

                case "how can i browse safely?":
                    Console.WriteLine("Here are some safe browsing tips:");
                    Console.WriteLine("- Use strong, unique passwords.");
                    Console.WriteLine("- Avoid downloading files from unknown sources.");
                    Console.WriteLine("- Keep your browser and antivirus software up to date.");
                    break;

                // Password Safety
                case "how can i create a strong password?":
                    Console.WriteLine("A strong password should:");
                    Console.WriteLine("- Be at least 12-16 characters long.");
                    Console.WriteLine("- Include uppercase, lowercase, numbers, and symbols.");
                    Console.WriteLine("- Avoid common words and personal information.");
                    Console.WriteLine("- Use a password manager to keep track of passwords.");
                    break;

                // Malware Protection
                case "what is malware?":
                    Console.WriteLine("Malware is malicious software designed to harm or exploit devices. Common types include:");
                    Console.WriteLine("- Viruses");
                    Console.WriteLine("- Trojans");
                    Console.WriteLine("- Ransomware");
                    Console.WriteLine("Always keep your antivirus updated and avoid downloading from unknown sources.");
                    break;

                case "how can i protect my device from malware?":
                    Console.WriteLine("Tips to protect your device from malware:");
                    Console.WriteLine("- Keep your operating system and software updated.");
                    Console.WriteLine("- Use a reputable antivirus program.");
                    Console.WriteLine("- Don't open email attachments from unknown sources.");
                    Console.WriteLine("- Avoid downloading software from untrusted websites.");
                    break;

                // Public Wi-Fi Risks
                case "is public wi-fi safe?":
                    Console.WriteLine("Public Wi-Fi is NOT secure! Hackers can intercept your data.");
                    Console.WriteLine("Use a VPN or mobile hotspot for better security.");
                    break;

                case "how can i stay safe on public wi-fi?":
                    Console.WriteLine("To stay safe on public Wi-Fi:");
                    Console.WriteLine("- Avoid accessing sensitive information (like banking).");
                    Console.WriteLine("- Use a VPN to encrypt your data.");
                    Console.WriteLine("- Disable automatic Wi-Fi connections.");
                    break;

                // Exit Option
                case "exit":
                    Console.Write("\nAre you sure you want to exit? (yes/no): ");
                    string exitConfirm = Console.ReadLine()?.Trim().ToLower();
                    if (exitConfirm == "yes")
                    {
                        Console.WriteLine("Goodbye! Stay safe online.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Let's continue.");
                    }
                    break;

                // Random Security Tips
                case "give me a security tip":
                    string[] securityTips = {
                        "Always enable two-factor authentication (2FA) for extra security.",
                        "Regularly update your passwords and never reuse them.",
                        "Be cautious of emails asking for personal information—always verify the sender.",
                        "Use a VPN when browsing on public Wi-Fi to stay secure.",
                        "Keep your operating system and apps updated to patch security vulnerabilities.",
                        "Use a password manager to generate and store strong passwords securely."
                    };

                    Random rnd = new Random();
                    Console.WriteLine(securityTips[rnd.Next(securityTips.Length)]);
                    break;

                default:
                    Console.WriteLine("I didn't quite understand that. Try asking about cybersecurity topics like phishing, malware, or password safety.");
                    break;
            }
        }
    }

    static void PlayGreeting()
    {
        try
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\RC_Student_lab\source\repos\S10444470.Peo_PART1\bin\Debug\Thutong Crescent (online-audio-converter.com).wav");
            soundPlayer.PlaySync();
            Console.WriteLine("Sound finished playing.");
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
}
