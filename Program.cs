// first task
// int NumberSum(int num)
// {
//     int sum = 0;
//     while (num != 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// void NumberRequest()
// {
//     while (true)
//     {
//         System.Console.Write("Enter your number: ");
//         string yourNumber = Console.ReadLine();
        
//         if (yourNumber == "q")
//             break;
        
//         if (int.TryParse(yourNumber, out int number))
//         {
//             if (NumberSum(number) % 2 == 0)
//                 break;
//         }
//         else
//             System.Console.WriteLine("wrong number!");
//     }
// }

// NumberRequest();

//second task

// int[] CreateArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)    
//     {
//         array[i] = new Random().Next(100, 999 + 1);
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
//     return array;
// }

// int CountEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// System.Console.Write("Enter array size: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CountEvenNumber(CreateArray(arraySize)));;

// third task

int[] CreateArray(int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)    
    {
        array[i] = new Random().Next(1, 99 + 1);
    }
    return array;
}

int[] ReversArray(int[] array)
{
    int tempNumber = 0;
    for (int i = 0; i < array.Length / 2; i++) 
    {
        tempNumber = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = tempNumber;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Enter array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(arraySize);
PrintArray(myArray);
System.Console.WriteLine("Reverse array: ");
PrintArray(ReversArray(myArray));
