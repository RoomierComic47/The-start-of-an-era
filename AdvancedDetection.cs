using System;
using System.Collections.Generic;

public class BotDetection
{
private List<string> botUsernames = new List<string>();

public BotDetection()
{
// Load bot list from BotList.txt (this can be expanded with actual file reading)
botUsernames.Add("streambot123");
botUsernames.Add("fakeviewer789");
botUsernames.Add("suspicious_bot");
botUsernames.Add("lurkingbot77");
botUsernames.Add("viewboostx");
}

public bool IsBot(string username)
{
// Check if username is in the bot list
return botUsernames.Contains(username);
}

public void DetectBotActivity(string username)
{
if (IsBot(username))
{
Console.WriteLine($"Suspicious bot detected: {username}");
// Further action can be taken, like reporting or banning the bot
}
else
{
Console.WriteLine($"User {username} seems legitimate.");
}
}
}

class Program
{
static void Main()
{
var botDetector = new BotDetection();
// Example usernames to test
botDetector.DetectBotActivity("streambot123");
botDetector.DetectBotActivity("legituser456");
}
}
