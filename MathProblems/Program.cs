using System.Linq;

#region Problem 1
//input
Console.WriteLine("===! PROBLEM 1 !===");
Console.WriteLine("Numbers count:");
int count = Convert.ToInt32(Console.ReadLine());
var numbers = new List<int>();
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Number { i + 1 }:");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
//algorithm
int? minDifference = null;
bool isProgression = true;
for (int i = 0; i < numbers.Count - 1; i++)
{
    int? difference = null;
    for (int j = 0; j < numbers.Count - 1; j++)
    {
        if (i != j && (difference == null ||
            difference > Math.Abs(numbers[i] - numbers[j])))
                difference = Math.Abs(numbers[i] - numbers[j]);
    }
    if (minDifference == null)
        minDifference = difference;
    else if (difference < minDifference)
    {
        isProgression = false;
        break;
    }
}
Console.WriteLine(isProgression ? "It's progression" : "It's not progression");
Console.WriteLine("Press any key to go to problem 2");
Console.ReadKey();
Console.Clear();
#endregion

#region Problem 2
Console.WriteLine("===! PROBLEM 2 !===");
Console.WriteLine("Experiment:");
var experiment = Console.ReadLine();
var result = String.Join("", experiment!
    .GroupBy(letter => letter)
    .Select(letterGroup => letterGroup.Key.ToString() + letterGroup.Count()));
Console.WriteLine($"Compounds: { result }");
Console.WriteLine("Press any key to exit");
Console.ReadLine();
#endregion

