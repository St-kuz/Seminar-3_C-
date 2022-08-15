Console.Clear();

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число, а я сообщу, является ли оно полиндромом: ");
int N = Convert.ToInt32(Console.ReadLine());
string palinprome = N.ToString();

if (10000>Math.Abs(N) || Math.Abs(N)>99999)
{
    Console.WriteLine("Вы ввели неверное число. Введите 5-ти значное число");
}

while (10000<Math.Abs(N) || Math.Abs(N)>9999)
{
    if (palinprome[0] == palinprome[4] && palinprome[1] == palinprome[3])
{
        Console.WriteLine("Да");
}
    else
{
        Console.WriteLine("Нет");
}
    break;
}



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double point (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
double length3D = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
return length3D;
}

Console.WriteLine("Введите координату X первой точки: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double Length = point (Xa, Ya, Za, Xb, Yb, Zb);
Console.WriteLine($"Расстояние между точками: " + Length);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число, а я выведу таблицу кубов всех чисел <= этому числу: ");

int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("| Число | Куб ");

for(int i = 1; i <= Num; i++)
{
Console.WriteLine("|-------|-------");
Console.WriteLine($"|___{i}___|__{i*i*i}__");
}