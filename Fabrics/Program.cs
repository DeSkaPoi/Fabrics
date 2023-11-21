using Fabrics.Abstraction;
using Fabrics.Commands;
using Fabrics.Fabrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<ICommand> queue = new Queue<ICommand>();
        int[] mas = new int[50];

        var readCommand = FabricCommands.CreateReadFileCommand(mas, "C:\\Users\\kntl\\Desktop\\in.txt");
        var writeCommand = FabricCommands.CreateWriteToFileCommand(mas, "C:\\Users\\kntl\\Desktop\\out.txt");
        
        queue.Enqueue(readCommand);

        Console.Write("Введите тип сортировки: \n1)Вставка\n2)Выбором\n3)Пузырьком\n");
        int? name = int.Parse(Console.ReadLine());
        switch (name)
        {
            case 1:
                var insertionSortCommand = FabricCommands.CreateSortCommand(SortType.Insertion, mas);
                queue.Enqueue(insertionSortCommand);
                break;
            case 2:
                var selectedSortCommand = FabricCommands.CreateSortCommand(SortType.Selection, mas);
                queue.Enqueue(selectedSortCommand);
                break; 
            case 3:
                var bubbleSortCommand = FabricCommands.CreateSortCommand(SortType.Bubble, mas);
                queue.Enqueue(bubbleSortCommand);
                break;
        }

        queue.Enqueue(writeCommand);
        var macro = FabricCommands.CreateMacroCommand(queue);

        macro.Execute();
    }
}