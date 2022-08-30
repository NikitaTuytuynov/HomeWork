// 1.Ввести первое число
// 2.Ввести второе число
// 3.Является ли первое число квадратом второго

Console.Clear();
Console.WriteLine("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 * num2 == num1)
{
    Console.WriteLine("Да");
}    
else
{
    Console.WriteLine("Нет");
}

