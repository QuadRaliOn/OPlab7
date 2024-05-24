// Melnichuk Andriy V-11
namespace OPlab7
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("H");
            var list = new MyList();
            list.Add(13);
            list.Add(5);
            list.Add(-1);
            list.Add(4);
            list.Add(-100);
            Instance b = list[3];
            int a = list.FindLength();
            Console.WriteLine(list.FindFirsNegative());
            Console.WriteLine(list.FindSumBiggerThenAvarage());
            var listPos = new MyList();
            listPos = list.CreatePositiveList();
            list.RemoveAllNegative();
            return;
        }
    }
}