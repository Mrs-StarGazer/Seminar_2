Console.WriteLine("введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int first = number / 10;
int second = first % 10;

Console.Write(second);
