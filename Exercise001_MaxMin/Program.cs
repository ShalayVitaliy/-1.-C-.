Console.Clear();
Console.Write("Введите число 1-ое: ");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
double n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"Большее: {n1} ; "  + "Меньшее:" + n2);
}
else {
    Console.WriteLine($"Большее: {n2} ; " + "Меньшее: " + n1);
}
