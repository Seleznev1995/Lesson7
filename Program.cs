
// int num(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SumOfElements(int n, int m)
// {
//   if (n == m) return n;
//   else return SumOfElements(n + 1, m) + n;
// }

// int n = num("Input N: ");
// int m = num("Input M: ");

// Console.WriteLine(SumOfElements(n, m));



// int num(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = num("Input M: ");
// int n = num("Input N: ");

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");


int[] array = new int[5];

void PrintArray(int[] arr, int count)
{
    if (count == arr.Length)
    {
        return;
    }

array[count]= new Random().Next(1,10);
Console.Write(array[count] + " ");
PrintArray(arr, count + 1);
}

void ReverseArray(int[] arr, int count)
{
    if (count == arr.Length)
    {
        return;
    }
    Console.Write(arr[arr.Length-1-count] + " ");
    ReverseArray(arr, count+1);
}
PrintArray(array, 0);
Console.WriteLine();
ReverseArray(array, 0);