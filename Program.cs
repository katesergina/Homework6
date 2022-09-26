// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел происходит через Enter, останавливается при введении слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


List<int> ReadNumbers(List<int>? nums = null) { 
    if (nums == null) { 
        nums = new List<int>(); 
    } 
    Console.WriteLine("Введите число или stop:"); 
    string value = Console.ReadLine(); 
    if (value != "stop") 
    { 
        nums.Add(int.Parse(value)); 
        ReadNumbers(nums); 
    } 
    return nums; 
} 
 
int CountPositiveValues(List<int> nums) { 
    int count = 0; 
    foreach (int num in nums) { 
        if (num > 0) { 
            count++; 
        } 
    } 
 
    return count; 
} 
 
List<int> nums = ReadNumbers(); 
Console.WriteLine(CountPositiveValues(nums));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadValue(string name) { 
    Console.WriteLine("Введите " + name + ":"); 
    return double.Parse(Console.ReadLine()); 
} 
 
void DisplayLinesCrossCoordinates(double k1, double k2, double b1, double b2) { 
    if ((k1 == k2) && (b1 == b2)) { 
        Console.WriteLine("Прямые совпадают"); 
    } else if (k1 == k2) { 
        Console.WriteLine("Прямые параллельны"); 
    } else { 
        double x = (b2 - b1) / (k1 - k2); 
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1; 
        Console.WriteLine("(" + x + ", " + y + ")"); 
    } 
} 
 
double b1 = ReadValue("b1"); 
double k1 = ReadValue("k1"); 
double b2 = ReadValue("b2"); 
double k2 = ReadValue("k2"); 
 
DisplayLinesCrossCoordinates(k1, k2, b1, b2);