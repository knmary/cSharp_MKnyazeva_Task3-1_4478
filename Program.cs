//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int ReadInt (string message)
{
    Console.Write(message);
    int value = Convert.ToInt32 (Console.ReadLine());
    return value;
}
bool NumberFives (int number)
{
    if (number >= 10000 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("ввод числа не корректный");
    return  false;
}


int num  = ReadInt("Введите пятизначное число >> ");
if (NumberFives(num))
{
    string NumberText = Convert.ToString(num);
    if (NumberText[0]==NumberText[4] || NumberText[1]==NumberText[3])
    {
         Console.WriteLine($"Ваше число: {NumberText} - палиндром");
    }
    else Console.WriteLine($"Ваше число: {NumberText} - НЕ палиндром.");
}   
