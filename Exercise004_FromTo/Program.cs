Console.Clear();
Console.Write("Введите конец промежутка: ");
int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начало промежутка: ");
// int i = Convert.ToInt32(Console.ReadLine());

// while (i <= num)
// {
//     if (i % 2 != 1)
//     {
//         Console.Write(i + ", ");
        
//     }
//      i++; 
// }


for (int i = 1; i  <= num;  i++){
    if (i % 2 != 1){
        Console.Write($"{i} ;");
    }
}   