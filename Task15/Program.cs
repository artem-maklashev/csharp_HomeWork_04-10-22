/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();

string SecondNumber(string secNumb)
{
    int result = 0;
    char[] arr = secNumb.ToCharArray();
    if (int.TryParse(secNumb, out result))
    {
        if (arr.Length == 1 && int.Parse(secNumb) > 0 && int.Parse(secNumb) <= 7)
        {
            if (int.Parse(arr[0].ToString()) == 6 ^ int.Parse(arr[0].ToString()) == 7)
                return "да";
            else return "нет";
        }
        else return "введенное число не попадает в диапазон 1-7 или превышает его";
    }
    else return "Было введено не число";
}
Console.Write("Введите номер дня недели: ");
string strNum = Console.ReadLine();
Console.WriteLine($"{strNum} -> {SecondNumber(strNum)}");