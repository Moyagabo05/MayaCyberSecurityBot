using System;
using System.Collections.Generic;
using System.Text;
using MayaCyberSecurityBot.Utilities;



namespace MayaCyberSecurityBot.Services
{
    
        public class ChatService
        {


        // AUTOMATIC PROPERTIES 
        public string UserName { get; set; } = "";
        public bool IsRunning { get; set; } = true;

        private readonly Dictionary<string, string> _definitions;
        public ChatService(Dictionary<string, string> defintions)
            {
                _definitions= defintions;
                
            }

            public void StartConversation()
            {

                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                // Get user name with validation
                Console.WriteLine("BOT:I will be assisting you today I will give you tips to stay safe online");

                while (string.IsNullOrWhiteSpace(UserName))
                {
                    Console.Write("BOT:Please enter your name: ");
                    UserName = Console.ReadLine();

                    //  Input Validation
                    if (string.IsNullOrWhiteSpace(UserName))
                    {
                        Console.WriteLine("BOT:Invalid input!");
                        Console.WriteLine("BOT:Name cannot be empty.");
                        Console.WriteLine("BOT:Please try again.");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                AsciiArt.TypeWriterEffect($"BOT: Welcome, {UserName}!", ConsoleColor.White, 30);
                Console.WriteLine();
                Thread.Sleep(500);

            //User must type 'help' to see menu
            Console.WriteLine("BOT:Type 'help' to see available topics, or 'exit' to quit.");
            Console.WriteLine();
           




            // Main chat loop
            while (IsRunning)
                {
                    Console.WriteLine();
                    Console.Write("You: ");

                string userInput = Console.ReadLine()??"";

                    //  Q5: Input Validation - Empty check
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("BOT:Invalid input!");
                        Console.WriteLine("BOT:Entry cannot be empty.");
                    continue;
                    }

                    // Check for exit
                    if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit" || userInput.ToLower() == "bye")
                    {
                        EndConversation();
                        break;
                    }

                    // Get and display response
                    string response = GetResponse(userInput);
                    DisplayResponse(response);
                }
            }

            //  Q6: Enhanced Response Display 
            private void DisplayResponse(string message)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("BOT:");
                Console.WriteLine(message);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            }

            

        public string GetResponse(string userInput)
        {
            string input = userInput.ToLower();

            // Special commands first
            if (input == "help")
            {
                DisplayHelpMenu();
                return "Type any topic above to learn more, or 'exit' to quit.";
            }
            if (input.Contains("hello") || input.Contains("hi"))
            {
                return $"Hi {UserName}! Type 'help' to see available topics.";
            }
           
            if (input.Contains("how are you"))
            {
                return $"I'm fully operational and ready to help, {UserName}! Ask me about any cybersecurity topic.";
            }

            if (input.Contains("purpose") || input.Contains("what can you do") || input.Contains("what can i ask"))
            {
                return "I'm Maya, your Cybersecurity Awareness Assistant! I can help you with:\n  - Passwords & authentication\n  - Phishing & scams\n  - Malware & viruses\n  - Safe browsing\n  - Privacy & data protection\n  - And much more! Type 'help' to see all topics.";
            }
            // Search the dictionary — return the first matching response
            foreach (KeyValuePair<string, string> entry in _definitions)
            {
                if (input.Contains(entry.Key))
                {
                    return entry.Value;
                }
            }

            // Nothing matched
            return "Bot:I didn't quite understand that. Could you rephrase?\n\nTry typing: password, phishing, malware, vpn, 2fa, privacy, browsing, backup, hacker, spoofing";
        }

        private void DisplayHelpMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== AVAILABLE SECURITY TOPICS ===");
            Console.WriteLine("  password          - Password security tips");
            Console.WriteLine("  phishing          - Email scam detection");
            Console.WriteLine("  malware           - Virus and ransomware protection");
            Console.WriteLine("  wifi / vpn        - Network security");
            Console.WriteLine("  2fa / mfa         - Two-factor authentication");
            Console.WriteLine("  privacy / data    - Protecting your personal info");
            Console.WriteLine("  browsing / https  - Safe internet usage");
            Console.WriteLine("  update / backup   - Keeping your device secure");
            Console.WriteLine("  hacker / breach   - Threats and attacks");
            Console.WriteLine("  spoofing          - Social engineering awareness");
            Console.WriteLine("  exit              - End conversation");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }



        private void EndConversation()
            {
                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine($"Thank you for chatting, {UserName}!");
                Console.WriteLine("Stay safe online!");
                Console.WriteLine("========================================");

                AsciiArt.TypeWriterEffect(">>> Disconnecting securely... <<<", ConsoleColor.White, 50);
            }
        }
    


}
