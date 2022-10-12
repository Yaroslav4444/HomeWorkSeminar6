/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int[] getCoordinat(int number)
{
    int[] startArray = new int[number];
    int numberI = 0;
    for (int i = 0; i < number; i++)
    {
        if (i == 0)
        {
            Console.WriteLine($"Введите первую координату прямой А");
            numberI = Convert.ToInt32(Console.ReadLine());
            startArray[i] = numberI;
        }
        if (i == 1)
        {
            Console.WriteLine($"Введите вторую координату прямой А");
            numberI = Convert.ToInt32(Console.ReadLine());
            startArray[i] = numberI;
        }
        if (i == 2)
        {

            Console.WriteLine($"Введите первую координату прямой Б");
            numberI = Convert.ToInt32(Console.ReadLine());
            startArray[i] = numberI;
        }
        if (i == 3)
        {

            Console.WriteLine($"Введите вторую координату прямой Б");
            numberI = Convert.ToInt32(Console.ReadLine());
            startArray[i] = numberI;
        }
    }
    return startArray;
}

double[] getXYValue(int[] inArray)
{
    double[] result = new double[2];
    result[0] = (double)(inArray[3] - inArray[1]) / (inArray[0] - inArray[2]);
    result[1] = inArray[0] * result[0] + inArray[1];
    return result;
}

void printArray(double[] Array)
{
    Console.Write("Координаты пересечения двух прямых : ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < (Array.Length - 1))
        {
            Console.Write(" ; ");
        }
    }
}

int number = 4;
int[] selfArray = getCoordinat(number);
double[] finishArray = getXYValue(selfArray);
printArray(finishArray);