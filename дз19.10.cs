//стр 38 №1
int summa = 0;
while (true)
{
    Console.WriteLine("Введите очередное число последовательности a=");
    int a = int.Parse(Console.ReadLine());
    if (a >= 0)
        summa += a;
    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
}
Console.WriteLine($"Сумма чисел summa= {summa}");

//стр 38 №4
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число послдедовательности, каждое нове числло с enter,а");
int P = int.Parse(Console.ReadLine());
int k = 0;
for (int i = 0; i < P; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a == N)
    {
        k++;
    }
}
Console.WriteLine($"Колличество числа {N} повторяется {k} раз(а)");

//стр 38 №6
Console.WriteLine("Введите значение больше 0");
int summa = int.Parse(Console.ReadLine());
while (true)
{
    Console.WriteLine("Введите очередное число последовательности a=");
    int x = int.Parse(Console.ReadLine());
    if (x >= 0)
        summa = x;
    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
}
Console.WriteLine($"Произведение чисел summa= {summa}");

//стр 38 №7
Console.WriteLine("количество чисел в последовательности");
int P = int.Parse(Console.ReadLine());
int summa = 0;
Console.WriteLine("Введите последовательность");
for (int i = 0; i < P; i++)
{
    Console.Write($"Введите число {i}: ");
    int a = int.Parse(Console.ReadLine());
    summa += Math.Abs(a);
}
Console.WriteLine($"summa = {summa}");

//стр 38 №9
double summa = 0;
while (true)
{
    Console.WriteLine("Введите очередное число последовательности a=");
    double c = int.Parse(Console.ReadLine());
    if (c >= 0)
        summa += Math.Pow(c, 2);
    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
}
Console.WriteLine($"Сумма квадратов последовательности равна = {summa}");

//стр 38 №10
Console.Write("Введите количество чисел в последовательности: ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
double SR;
for (int i = 1; i <= n; i++)
{
    Console.Write($"Введите число {i}: ");
    double number = double.Parse(Console.ReadLine());

    sum += number;
}
SR = sum / n;
Console.WriteLine($"Среднее арифметическое: {SR}");

//стр 38 №12
Console.Write("Введите количество чисел в последовательности: ");
int n = int.Parse(Console.ReadLine());
double qwe = 1;
for (int i = 1; i <= n; i++)
{
    Console.Write($"Введите число {i}: ");
    double number = double.Parse(Console.ReadLine());
    double zxc = Math.Abs(number);
    qwe *= zxc;
}
Console.WriteLine($"Произведение модулей элементов последовательности: {qwe}");

//стр 41 №1
int u;
int y;
int x = 0;
int P;
int sum;
Console.WriteLine("Введите натуральное число n");
u = Convert.ToInt32(Console.ReadLine());
P = u;
while (u != 0)
{
    if (u / 10 == 0)
        x = u;
    u /= 10;
}
y = P % 10;
sum = x + y;
Console.WriteLine($"сумма первого и последнего числа равны = {sum}");

//стр 43 №1
Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine());
int F = 0;
int Z = n % 10;
while (n > 0)
{
    F = n % 10;
    n /= 10;
    if (n < 10)
        break;
}
int sum = F + Z;
Console.WriteLine($"Сумма первой и последней цифры числа: {sum}");

//стр 36 №1 б
Console.WriteLine("Введите значение eps=");
double eps = double.Parse(Console.ReadLine());
double summa = 0;
int d = 1;
double a;
do
{
    a = 1.0 / (Math.Pow(2.0, d)) + 1.0 / (Math.Pow(3.0, d));
    summa += a;
    d++;
}
while (Math.Abs(a) >= eps);
Console.WriteLine($"Сумма последовательности summa={summa}")

//стр 33 №3
Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine());
double product = 1.0;

for (double k = 1.0; k <= n; k++)
{
    double P = (2 * k) / (2 * k + 1);
    product *= P;
}
Console.WriteLine($"Произведение первых {n} сомножителей: {product}");
