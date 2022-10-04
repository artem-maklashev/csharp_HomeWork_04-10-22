/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

string SecondNumber(string? secNumb)
{
    int result = 0;
    char [] arr = secNumb.ToCharArray();
    if (int.TryParse(secNumb, out result))
    {
        string secondElement = secNumb[1].ToString();
        return secondElement;
    }
    else return "Было введено не число"; 
}
Console.Write("Введите число: ");
string? strNum = Console.ReadLine();
Console.WriteLine($"{strNum} -> {SecondNumber(strNum)}");
