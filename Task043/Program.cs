// Задача 43: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[] stringArray = Console.ReadLine().Split(' ');

double b1 = double.Parse(stringArray[0]);
double b2 = double.Parse(stringArray[1]);
double k1 = double.Parse(stringArray[2]);
double k2 = double.Parse(stringArray[3]);

double[] GetPoint(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;

    return result;
}

Console.WriteLine(string.Join(" ", GetPoint(b1, b2, k1, k2)));
