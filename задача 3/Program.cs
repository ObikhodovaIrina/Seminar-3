//  Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int index = 1; number >= index; index ++)
{
    int newNumber = Cube(index);
    Console.WriteLine($"{index} -> {newNumber}" );
}



int Cube(int index)
{
    return index = index * index * index; 
}