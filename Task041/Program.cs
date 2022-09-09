//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит
// через Enter, останавливается при введении слова "stop"
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void PositiveNumber()
{
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    int count = 0;
    if (number == "stop")
    {
        Console.WriteLine(count);
    }
    else
    {
        int num = Convert.ToInt32(number);
        if (num > 0) count++;
    }
    Console.WriteLine(count);
}
PositiveNumber();