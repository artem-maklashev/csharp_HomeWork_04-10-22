/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();

string SecondNumber(string secNumb)
{
    int result = 0;
    if (int.TryParse(secNumb, out result))
    {
        if (int.Parse(secNumb) > 0 && int.Parse(secNumb) <= 7)
        {
            if (int.Parse(secNumb) == 6 ^ int.Parse(secNumb) == 7)
                return "да, это выходной";
            else return "нет, это рабочий день";
        }
        else return "введенное число не попадает в диапазон 1-7 или превышает его";
    }
    else return "Было введено не число";
}
Console.Write("Введите номер дня недели: ");
string strNum = Console.ReadLine();
int.TryParse(strNum, out int s1);
var s = (DayOfTheWeek)s1;
Console.WriteLine($"{strNum} -> {s} -> {SecondNumber(strNum)}");

enum DayOfTheWeek { Понедельник = 1, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье };