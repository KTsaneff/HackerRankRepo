int rows = int.Parse(Console.ReadLine());

List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < rows; i++)
{
    List<int> list = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList();

    arr.Add(list);
}

int difference = DiagonalDifference(arr);
Console.WriteLine(difference);

static int DiagonalDifference(List<List<int>> arr)
{
    int sumFirstDiagonal = 0;
    int sumSecondDiagonal = 0;

    int firstCounter = 0;
    int secondCounter = arr.Count -1;

    for (int i = 0; i < arr.Count; i++)
    {
        sumFirstDiagonal += arr[i][firstCounter];
        sumSecondDiagonal += arr[i][secondCounter];

        firstCounter++;
        secondCounter--;
    }

    return Math.Abs(sumFirstDiagonal - sumSecondDiagonal);
}
