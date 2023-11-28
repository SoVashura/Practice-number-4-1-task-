using System;
using System.Linq;

class Program
{
static void Main()
    {
string[] months = { "June", "July", "May", "December", "January", "February", "March", "April", "August", "September", "October", "November" };

// Выбор месяцев с длиной строки равной n
int n = 7;
var monthsWithLengthN = months.Where(month => month.Length == n);

Console.WriteLine("Месяцы с длиной строки равной " + n + ":");
foreach (var month in monthsWithLengthN)
{
    Console.WriteLine(month);
}

// Выбор только летних и зимних месяцев

var summerAndWinterMonths = months.Where(month =>
            month == "June" || month == "July" || month == "August" ||
            month == "December" || month == "January" || month == "February");

Console.WriteLine("Летние и зимние месяцы:");
foreach (var month in summerAndWinterMonths)
{
    Console.WriteLine(month);
}


// Вывод месяцев в алфавитном порядке
var monthsInAlphabeticalOrder = months.OrderBy(month => month);

Console.WriteLine("\nМесяцы в алфавитном порядке:");
foreach (var month in monthsInAlphabeticalOrder)
{
    Console.WriteLine(month);
}

// Подсчет месяцев, содержащих букву "u" и длиной имени не менее 4-х
var monthsWithUAndLengthAtLeast4 = months.Where(month => month.Contains("u") && month.Length >= 4);

Console.WriteLine("\nМесяцы, содержащие 'u' и имеющие длину не менее 4-х символов:");
foreach (var month in monthsWithUAndLengthAtLeast4)
{
    Console.WriteLine(month);
}
    }
}
