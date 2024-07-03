class ChangeList
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = "";
        while ((command=Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split(" ");
            string operation = commandArgs[0];
            if (operation == "Delete")
            {
                Delete (commandArgs,numbers);
            }
            else if (operation == "Insert")
            {
                Insert(commandArgs, numbers);
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    private static void Delete(string[] commandArgs, List<int> numbers)
    {
        int elementRemoval = int.Parse(commandArgs[1]);
        while (numbers.Contains(elementRemoval))
        {
            numbers.Remove(elementRemoval);
        }
    }

    private static void Insert(string[] commandArgs, List<int> numbers)
    {
        int index = int.Parse(commandArgs[2]);
        int elementAdding = int.Parse(commandArgs[1]);
        numbers.Insert(index, elementAdding);
    }
}


