using System;

class GaCo1
{
    private const int maxGarbage = 1000;

    static void Main()
    {
       
        GaCo1.MakeSomeGarbage();
        Console.WriteLine("Memory used before collection:       {0:N0}",
                        GC.GetTotalMemory(false));
        GC.Collect();
        Console.WriteLine("Memory used before collection:       {0:N0}",
                        GC.GetTotalMemory(true));
        Console.ReadKey();
    }

    static void MakeSomeGarbage()
    {
        for (int i = 0; i < maxGarbage; i++)
        {
            GaCo1 obj = new GaCo1();
        }
    }
}