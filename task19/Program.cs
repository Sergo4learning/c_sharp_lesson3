// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int get_num()
{
    Console.Write("Введите пятизначное число: ");
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}
string is_it_palindrome(int num)
{
    string result="Нет";
    int[] singl_num = new int[5];
    for (int i = 0; i<=4; i++)
    {
        singl_num[i] = num/Convert.ToInt32(Math.Pow(10,i))%10;
    }
    if (singl_num[0]==singl_num[4] & singl_num[1]==singl_num[3])
    {
        result="Да";
    }
    return result;
}
string rez = "Введённое число не соответствует параметрам задачи.";
int number = get_num();
if (number>9999&number<100000)
{
    rez=is_it_palindrome(number);    
}
Console.WriteLine(rez);
