Console.Clear();
Console.Write("Введите число 1-ое: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3-ье: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max){
    max = n2;
}

if (n3 > max){
    max = n3;
}

Console.WriteLine(max);

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {132, 23, 31};

// int max = Max(array[0], array[1], array[2]);

// Console.WriteLine(max);


// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//     }
// } 

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[3];

// FillArray(array);
// PrintArray(array);