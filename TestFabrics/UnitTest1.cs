using Fabrics.Abstraction;
using Fabrics.Fabrics;

namespace TestFabrics
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Queue<ICommand> queue = new Queue<ICommand>();
            int[] mas = new int[] { 10, 2, 3, 7, 1 };

            var readCommand = FabricCommands.CreateReadFileCommand(mas, "C:\\Users\\kntl\\Desktop\\in.txt");
            var writeCommand = FabricCommands.CreateWriteToFileCommand(mas, "C:\\Users\\kntl\\Desktop\\out.txt");

            queue.Enqueue(readCommand);

            Console.Write("Введите тип сортировки: \n1)Вставка\n2)Выбором\n3)Пузырьком\n");
            var insertionSortCommand = FabricCommands.CreateSortCommand(SortType.Insertion, mas);
            queue.Enqueue(insertionSortCommand);
            queue.Enqueue(writeCommand);
            var macro = FabricCommands.CreateMacroCommand(queue);
            macro.Execute();

            Assert.Equal(mas, new int[] { 1, 2, 3, 7, 10 });
        }
    }
}