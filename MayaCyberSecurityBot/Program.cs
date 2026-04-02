using MayaCyberSecurityBot.Utilities;
using MayaCyberSecurityBot.Services;
using MayaCyberSecurityBot;
using System;
using System.Text;



namespace MayaCyberSecurityBot
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> definitions = new Dictionary<string, string>
{
    // --- Passwords ---
    { "password",    "[PASSWORDS] Tips:\n  - Use 12+ characters\n  - Mix letters, numbers and symbols\n  - Never reuse passwords\n  - Use a password manager" },
    { "passphrase",  "[PASSWORDS] Tips:\n  - Use 12+ characters\n  - Mix letters, numbers and symbols\n  - Never reuse passwords\n  - Use a password manager" },
    { "pin",         "[PASSWORDS] Tips:\n  - Use 12+ characters\n  - Mix letters, numbers and symbols\n  - Never reuse passwords\n  - Use a password manager" },
    { "login",       "[PASSWORDS] Tips:\n  - Use 12+ characters\n  - Mix letters, numbers and symbols\n  - Never reuse passwords\n  - Use a password manager" },
    { "credentials", "[PASSWORDS] Tips:\n  - Use 12+ characters\n  - Mix letters, numbers and symbols\n  - Never reuse passwords\n  - Use a password manager" },

    // --- Phishing ---
    { "phishing",  "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },
    { "scam",      "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },
    { "spam",      "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },
    { "smishing",  "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },
    { "vishing",   "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },
    { "email",     "[PHISHING] Watch out for:\n  - Fake sender addresses\n  - Urgent threats\n  - Links that don't match the text\n  - Requests for personal info" },

    // --- Malware ---
    { "malware",    "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },
    { "virus",      "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },
    { "ransomware", "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },
    { "trojan",     "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },
    { "spyware",    "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },
    { "worm",       "[MALWARE] Protection:\n  - Keep antivirus updated\n  - Don't download unknown files\n  - Update your OS regularly" },

    // --- Network Security ---
    { "wifi",     "[NETWORK] Stay safe:\n  - Use a VPN on public WiFi\n  - Keep your router firmware updated\n  - Enable your firewall\n  - Use WPA3 encryption if available" },
    { "vpn",      "[NETWORK] Stay safe:\n  - Use a VPN on public WiFi\n  - Keep your router firmware updated\n  - Enable your firewall\n  - Use WPA3 encryption if available" },
    { "firewall", "[NETWORK] Stay safe:\n  - Use a VPN on public WiFi\n  - Keep your router firmware updated\n  - Enable your firewall\n  - Use WPA3 encryption if available" },
    { "network",  "[NETWORK] Stay safe:\n  - Use a VPN on public WiFi\n  - Keep your router firmware updated\n  - Enable your firewall\n  - Use WPA3 encryption if available" },
    { "router",   "[NETWORK] Stay safe:\n  - Use a VPN on public WiFi\n  - Keep your router firmware updated\n  - Enable your firewall\n  - Use WPA3 encryption if available" },

    // --- Authentication ---
    { "2fa",            "[2FA] Two-Factor Authentication:\n  - Always enable when available\n  - Use an authenticator app, not SMS\n  - Save backup codes safely" },
    { "mfa",            "[2FA] Two-Factor Authentication:\n  - Always enable when available\n  - Use an authenticator app, not SMS\n  - Save backup codes safely" },
    { "authentication", "[2FA] Two-Factor Authentication:\n  - Always enable when available\n  - Use an authenticator app, not SMS\n  - Save backup codes safely" },
    { "biometrics",     "[2FA] Two-Factor Authentication:\n  - Always enable when available\n  - Use an authenticator app, not SMS\n  - Save backup codes safely" },
    { "token",          "[2FA] Two-Factor Authentication:\n  - Always enable when available\n  - Use an authenticator app, not SMS\n  - Save backup codes safely" },

    // --- Privacy ---
    { "privacy",  "[PRIVACY] Protect your data:\n  - Review app permissions regularly\n  - Manage cookie settings in your browser\n  - Know your rights under POPIA/GDPR" },
    { "data",     "[PRIVACY] Protect your data:\n  - Review app permissions regularly\n  - Manage cookie settings in your browser\n  - Know your rights under POPIA/GDPR" },
    { "cookie",   "[PRIVACY] Protect your data:\n  - Review app permissions regularly\n  - Manage cookie settings in your browser\n  - Know your rights under POPIA/GDPR" },
    { "tracking", "[PRIVACY] Protect your data:\n  - Review app permissions regularly\n  - Manage cookie settings in your browser\n  - Know your rights under POPIA/GDPR" },
    { "gdpr",     "[PRIVACY] Protect your data:\n  - Review app permissions regularly\n  - Manage cookie settings in your browser\n  - Know your rights under POPIA/GDPR" },

    // --- Safe Browsing ---
    { "browsing",  "[BROWSING] Safe surfing:\n  - Look for https:// and the padlock icon\n  - Avoid banking on public WiFi\n  - Don't click suspicious links\n  - Clear cookies regularly" },
    { "https",     "[BROWSING] Safe surfing:\n  - Look for https:// and the padlock icon\n  - Avoid banking on public WiFi\n  - Don't click suspicious links\n  - Clear cookies regularly" },
    { "url",       "[BROWSING] Safe surfing:\n  - Look for https:// and the padlock icon\n  - Avoid banking on public WiFi\n  - Don't click suspicious links\n  - Clear cookies regularly" },
    { "download",  "[BROWSING] Safe surfing:\n  - Look for https:// and the padlock icon\n  - Avoid banking on public WiFi\n  - Don't click suspicious links\n  - Clear cookies regularly" },
    { "browser",   "[BROWSING] Safe surfing:\n  - Look for https:// and the padlock icon\n  - Avoid banking on public WiFi\n  - Don't click suspicious links\n  - Clear cookies regularly" },

    // --- Device Security ---
    { "update",     "[DEVICE] Keep your device secure:\n  - Install OS and app updates promptly\n  - Run reputable antivirus software\n  - Back up data regularly (3-2-1 rule)\n  - Encrypt your hard drive" },
    { "patch",      "[DEVICE] Keep your device secure:\n  - Install OS and app updates promptly\n  - Run reputable antivirus software\n  - Back up data regularly (3-2-1 rule)\n  - Encrypt your hard drive" },
    { "antivirus",  "[DEVICE] Keep your device secure:\n  - Install OS and app updates promptly\n  - Run reputable antivirus software\n  - Back up data regularly (3-2-1 rule)\n  - Encrypt your hard drive" },
    { "backup",     "[DEVICE] Keep your device secure:\n  - Install OS and app updates promptly\n  - Run reputable antivirus software\n  - Back up data regularly (3-2-1 rule)\n  - Encrypt your hard drive" },
    { "encryption", "[DEVICE] Keep your device secure:\n  - Install OS and app updates promptly\n  - Run reputable antivirus software\n  - Back up data regularly (3-2-1 rule)\n  - Encrypt your hard drive" },

    // --- Threats & Attacks ---
    { "hacker",   "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },
    { "breach",   "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },
    { "attack",   "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },
    { "ddos",     "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },
    { "identity", "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },
    { "darkweb",  "[THREATS] Stay alert:\n  - Monitor accounts for unusual activity\n  - Use breach-checking tools (e.g. haveibeenpwned.com)\n  - Freeze credit if your identity is compromised" },

    // --- Social Engineering ---
    { "spoofing",            "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "pretexting",          "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "baiting",             "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "tailgating",          "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "manipulation",        "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "impersonation",       "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
    { "social engineering",  "[SOCIAL ENGINEERING] Be sceptical:\n  - Verify unexpected requests out-of-band\n  - Don't share info under pressure or urgency\n  - Attackers often impersonate trusted people" },
};
            // Enable UTF-8 for ASCII art symbols
            Console.OutputEncoding = Encoding.UTF8;

            
            Console.Clear(); // Apply background color

            // Set default text color
            Console.ForegroundColor = ConsoleColor.White;

            // Clear console for clean start
            Console.Clear();

            // 1. Display ASCII Header
            AsciiArt.DisplayLogo();

            // 2. Play Voice Greeting
            AudioPlayer.PlayGreeting();

            // 3. Start the Chat
            ChatService chatService = new ChatService(definitions);
            chatService.StartConversation();
        }
    }
}