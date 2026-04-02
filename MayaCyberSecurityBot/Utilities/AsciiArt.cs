namespace MayaCyberSecurityBot.Utilities
{
    public static class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //  ASCII Art
            Console.WriteLine(@"
╔────────────────────────────────────────────────────────────────────────────╗
│ _ _                                                                   _ _  │
│( Y ) ║══════════════════════════════════════════════════════════════╗( Y ) │
│ \ /  ║                  .----------------------.                    ║ \ /  │
│  Y   ║                  |MAYA CYBERSECURITY BOT|                    ║  Y   │
│      ═                  '----------------------'                    ═      │
│      ║                                                              ║      │
│      ║                                                              ║      │
│      ║                                                              ║      │
│      ═                [ NETWORK SECURITY ACTIVE!! ]                 ═      │
│ _ _  ║                                                              ║  _ _ │
│( Y ) ║          PROTECTING SOUTH AFRICAN DIGITAL CITIZENS           ║ ( Y )│
│ \ /  ║                                                              ║  \ / │
│  Y   ╚═══════════════════════════════════════════════════════════════   Y  │
╚────────────────────────────────────────────────────────────────────────────╝
");
            Console.ResetColor();

            // Typing effect for welcome message
            Console.WriteLine();
            TypeWriterEffect("Welcome to Your Cybersecurity Awareness Assistant ", ConsoleColor.White, 50);
            Console.WriteLine();
        }

        // Typing effect method
        public static void TypeWriterEffect(string text, ConsoleColor color, int delayMs = 50)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }


}
