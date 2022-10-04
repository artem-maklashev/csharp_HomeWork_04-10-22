/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Clear();

string SecondNumber(string secNumb)
{
    Int64 result = 0;
    char[] arr = secNumb.ToCharArray();
    if (Int64.TryParse(secNumb, out result)) //Int64 если пользователь вводит число больше чем Int32
    {
        if (arr.Length > 2)
        {
            string secondElement = secNumb[2].ToString();
            return secondElement;
        }
        else return "третьей цифры нет";
    }
    else return "Было введено не число";
}
Console.Write("Введите число: ");
string strNum = Console.ReadLine();
Console.WriteLine($"{strNum} -> {SecondNumber(strNum)}");