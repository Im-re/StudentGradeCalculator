double grade1 = 0, grade2 = 0, grade3 = 0;

Console.Write("Enter the student's first grade: ");

string answer1 = Console.ReadLine();

while (true)
{
    if (double.TryParse(answer1, out grade1) && grade1 >= 0 && grade1 <= 100)
    {
        Console.WriteLine("Entered grade: " + grade1);
        Console.Write("Enter the student's second grade: ");
        break;
    }
    else
    {
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
        answer1 = Console.ReadLine();
    }
}

while (true)
{
    string answer2 = Console.ReadLine();

    if (double.TryParse(answer2, out grade2) && grade2 >= 0 && grade2 <= 100)
    {
        Console.WriteLine("Entered grade: " + grade2);
        Console.Write("Enter the student's third grade: ");
        break;
    }
    else
    {
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
        answer2 = Console.ReadLine();
    }
}

while (true)
{
    string answer3 = Console.ReadLine();

    if (double.TryParse(answer3, out grade3) && grade3 >= 0 && grade3 <= 100)
    {
        Console.WriteLine("Entered grade: " + grade3);
        break;
    }
    else
    {
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
        answer3 = Console.ReadLine();
    }
}

double average = (grade1 + grade2 + grade3) / 3;

if (average >= 85)
{
    Console.WriteLine($"The student received an Honor Certificate. Average: {average:0.###}");
}
else if (average >= 70)
{
    Console.WriteLine($"The student received an Appreciation Certificate. Average: {average:0.###}");
}
else
{
    Console.WriteLine($"The student failed. Average: {average:0.###}");
}
