// Название дня недели в зависимости от выбранного числа

Console.Write("Введите номер дня недели [1..7]");
int number = int.Parse(Console.ReadLine());
//Console.WriteLine(number);

if (number == 1) Console.WriteLine("Вы выбрали понедельник");
if (number == 2) Console.WriteLine("Вы выбрали вторник");
if (number == 3) Console.WriteLine("Вы выбрали среду");
if (number == 4) Console.WriteLine("Вы выбрали четверг");
if (number == 5) Console.WriteLine("Вы выбрали пятницу");
if (number == 6) Console.WriteLine("Вы выбрали субботу");
if (number == 7) Console.WriteLine("Вы выбрали воскресенье");
Console.WriteLine("Сегодня прекрасный день!")