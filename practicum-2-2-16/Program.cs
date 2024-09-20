Console.Write("Введите коэффициент a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите коэффициент b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите коэффициент c: ");
double c = double.Parse(Console.ReadLine());

string equation_text = string.Format("{0}x^2 + {1}x + {2}", a, b, c);
Console.WriteLine((b * b - 4 * a * c) >= 0 ? equation_text + " имеет решение" : equation_text + " не имеет решения");
