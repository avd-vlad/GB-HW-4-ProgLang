/*----------------------------------------------------------------------------------------------------------------------
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
----------------------------------------------------------------------------------------------------------------------*/

void FillAndPrintArray(int num)
{
    int[] x = new int[num];
    for(int i=0; i<num;i++)
    {
        Console.Write($"Please enter x[{i}]: ");
        x[i]=Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Array you entered is: [");

    for(int i=0; i<num;i++)
    {
        if(i==num-1)
            Console.Write($"{x[i]}");
        else
            Console.Write($"{x[i]},");
    }
    Console.WriteLine("]");
}

Console.Write("Please enter array size: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
FillAndPrintArray(arrSize);

