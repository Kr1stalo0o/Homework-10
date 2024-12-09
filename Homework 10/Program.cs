using System.Text;


////10.1
//Console.WriteLine("Enter name and nickname:");
//string input = Console.ReadLine()?.Trim();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Please enter your first and last name.");
//    return;
//}

//string[] parts = input.Split(' ');
//if (parts.Length != 2)
//{
//    Console.WriteLine("Please enter only first and last name separated by a space.");
//    return;
//}

//string firstName = parts[0];
//string lastName = parts[1];

//if (firstName.Length > 0 && lastName.Length > 0 &&
//    char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
//{
//    Console.WriteLine("The surname begins with the same letter as the first name.");
//}
//else
//{
//    Console.WriteLine("The last name does not start with the same letter as the first name.");
//}

//10.2

//StringBuilder report = new StringBuilder();
//StringBuilder events = new StringBuilder();

//string title = "Text report";
//string date = DateTime.Now.ToString("yyyy-MM-dd");

//report.AppendLine(title);
//report.AppendLine($"Date: {date}");
//report.AppendLine();

//Console.WriteLine("Enter the events for the report (enter 'finish' to finish):");

//while (true)
//{
//    Console.Write("Event: ");
//    string input = Console.ReadLine();

//    if (input?.ToLower() == "finish")
//    {
//        break;
//    }

//    if (!string.IsNullOrWhiteSpace(input))
//    {
//        events.AppendLine($"- {input}");
//    }
//}

//report.AppendLine("List of events:");
//report.Append(events);

//Console.WriteLine("\nReport:");
//Console.WriteLine(report.ToString());

//10.3

Console.WriteLine("Enter a string of words separated by commas:");
string input = Console.ReadLine();

string result = input.Replace(" ", "");

Console.WriteLine($"Result: {result}");