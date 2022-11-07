using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        var inputs = sr.ReadToEnd().Split("\r\n").Where(x => x!= "").ToList();

        foreach (var line in inputs)
        {
            string[] input = line.Split(';', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            //Split

            if (input[0] == "S")
            {
                //Method

                if (input[1] == "M")
                {
                    string param = input[2].Split('(')[0];
                    Queue<int> capsPositions = new Queue<int>();
                    capsPositions.Enqueue(0);

                    foreach (char element in param)
                    {
                        if ((int)element >= 65 && (int)element <= 90)
                        {
                            var index = param.IndexOf(element);
                            capsPositions.Enqueue((int)index);
                        }
                    }

                    while (capsPositions.Count > 1)
                    {
                        int currIndex = capsPositions.Dequeue();
                        string word = param.Substring(currIndex, capsPositions.Peek() - currIndex);
                        sb.Append(word.ToLower());
                        sb.Append(" ");
                    }

                    int lastIndex = capsPositions.Dequeue();
                    string lastWord = param.Substring(lastIndex, (param.Length) - lastIndex);
                    sb.Append(lastWord.ToLower());

                    Console.WriteLine(sb.ToString().TrimEnd());
                }

                //Class

                if (input[1] == "C")
                {
                    string param = input[2];
                    Queue<int> capsPositions = new Queue<int>();

                    foreach (char element in param)
                    {
                        if ((int)element >= 65 && (int)element <= 90)
                        {
                            var index = param.IndexOf(element);
                            capsPositions.Enqueue((int)index);
                        }
                    }

                    while (capsPositions.Count > 1)
                    {
                        int currIndex = capsPositions.Dequeue();
                        string word = param.Substring(currIndex, capsPositions.Peek() - currIndex);
                        sb.Append(word.ToLower());
                        sb.Append(" ");
                    }

                    int lastIndex = capsPositions.Dequeue();
                    string lastWord = param.Substring(lastIndex, (param.Length) - lastIndex);
                    sb.Append(lastWord.ToLower());

                    Console.WriteLine(sb.ToString().TrimEnd());
                }

                //Variable

                if (input[1] == "V")
                {
                    string param = input[2];
                    Queue<int> capsPositions = new Queue<int>();
                    capsPositions.Enqueue(0);

                    foreach (char element in param)
                    {
                        if ((int)element >= 65 && (int)element <= 90)
                        {
                            var index = param.IndexOf(element);
                            capsPositions.Enqueue((int)index);
                        }
                    }

                    while (capsPositions.Count > 1)
                    {
                        int currIndex = capsPositions.Dequeue();
                        string word = param.Substring(currIndex, capsPositions.Peek() - currIndex);
                        sb.Append(word.ToLower());
                        sb.Append(" ");
                    }

                    int lastIndex = capsPositions.Dequeue();
                    string lastWord = param.Substring(lastIndex, (param.Length) - lastIndex);
                    sb.Append(lastWord.ToLower());

                    Console.WriteLine(sb.ToString().TrimEnd());
                }
            }

            //Combine

            else if (input[0] == "C")
            {
                string[] param = input[2].Split(" ");
                //Method

                if (input[1] == "M")
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(param[0]);
                    }

                    for (int i = 1; i < param.Length; i++)
                    {
                        string paramToAdd = param[i][0].ToString().ToUpper() + param[i].Substring(1);
                        sb.Append(paramToAdd);
                    }

                    sb.Append("()");

                    Console.WriteLine(sb.ToString().TrimEnd());
                }

                //Class

                if (input[1] == "C")
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        string paramToAdd = param[i][0].ToString().ToUpper() + param[i].Substring(1);
                        sb.Append(paramToAdd);
                    }

                    Console.WriteLine(sb.ToString().TrimEnd());
                }

                //Variable

                if (input[1] == "V")
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(param[0]);
                    }

                    for (int i = 1; i < param.Length; i++)
                    {
                        string paramToAdd = param[i][0].ToString().ToUpper() + param[i].Substring(1);
                        sb.Append(paramToAdd);
                    }

                    Console.WriteLine(sb.ToString().TrimEnd());
                }
            }
        }
    }

}
