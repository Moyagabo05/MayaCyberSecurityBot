# Maya Cybersecurity Awareness Bot

A console-based cybersecurity awareness chatbot built in C# for South African digital citizens.
Maya educates users on online safety topics through an interactive conversational interface,
complete with a voice greeting, ASCII art display, and a typewriter effect.

---

## Project Structure

```
MayaCyberSecurityBot/
├── Assets/
│   └── greeting.wav          # Voice greeting audio file
├── Services/
│   └── ChatService.cs        # Main chat loop and response logic
├── Utilities/
│   ├── AsciiArt.cs           # ASCII logo and typewriter effect
│   └── AudioPlayer.cs        # WAV audio playback
├── Program.cs                # Entry point and keyword dictionary
└── README.md                 # This file
```

---

## Features

- Voice greeting — plays a personalised WAV audio message on startup
- ASCII art header — displays a cybersecurity-themed logo
- 50-keyword response system — covers 10 cybersecurity topics
- Input validation — handles empty input and unrecognised queries gracefully
- Enhanced console UI — coloured text, borders, and typewriter animation
- Personalised responses — uses the user's name throughout the session

---

## Topics Covered

| Topic | Example keywords |
|---|---|
| Passwords | password, passphrase, credentials, pin, login |
| Phishing | phishing, scam, spam, smishing, vishing, email |
| Malware | malware, virus, ransomware, trojan, spyware, worm |
| Network Security | wifi, vpn, firewall, network, router |
| Authentication | 2fa, mfa, authentication, biometrics, token |
| Privacy | privacy, data, cookie, tracking, gdpr |
| Safe Browsing | browsing, https, url, download, browser |
| Device Security | update, patch, antivirus, backup, encryption |
| Threats & Attacks | hacker, breach, attack, ddos, identity, darkweb |
| Social Engineering | spoofing, pretexting, baiting, manipulation, impersonation |

---

## Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- [NAudio](https://github.com/naudio/NAudio) NuGet package (for audio playback)
- Windows OS recommended (NAudio uses Windows audio APIs)

---

## How to Run

### 1. Clone the repository

```bash
git clone https://github.com/Moyagabo05/MayaCyberSecurityBot.git
cd MayaCyberSecurityBot
```

### 2. Restore NuGet packages

```bash
dotnet restore
```

### 3. Build the project

```bash
dotnet build
```

### 4. Run the application

```bash
dotnet run
```

> **Note:** Make sure the `Assets/greeting.wav` file is present in the project folder.
> If it is missing, the bot will display a text fallback greeting and continue normally.

---

## Usage

Once the bot launches:

1. The ASCII art logo and voice greeting will play automatically
2. Enter your name when prompted
3. Type any cybersecurity topic to receive tips (e.g. `password`, `phishing`, `vpn`)
4. Type `help` to see all available topics
5. Type `exit`, `quit`, or `bye` to end the session

**Example interaction:**
```
You: phishing
BOT: [PHISHING] Watch out for:
  - Fake sender addresses
  - Urgent threats
  - Links that don't match the text
  - Requests for personal info
```

---

## GitHub Actions (CI)

This project uses GitHub Actions for Continuous Integration.
On every push, the workflow automatically builds the project and checks for errors.

The workflow file is located at `.github/workflows/build.yml`.

A green check mark on each commit confirms the build is passing.

---

## Author

- **Student Name:** Moyagabo Raphasha
- **Student Number:** st10471918
- **Module:** Programming 2A — PROG6221
- **Institution:** The Independent Institute of Education (The IIE)Rosebank Collage 
