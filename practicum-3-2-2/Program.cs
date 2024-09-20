Console.Write("Введите значение x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите значение y: ");
double y = double.Parse(Console.ReadLine());

double circle = x * x + y * y;

if (circle == 9 || circle == 49) {
  Console.WriteLine("На границе");
} else if (circle < 49 && circle > 9) {
  Console.WriteLine("Да");
} else {
  Console.WriteLine("Нет");
}
