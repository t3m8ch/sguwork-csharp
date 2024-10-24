Console.Write("Введите размер массива n = ");
uint n = uint.Parse(Console.ReadLine());

int[][] array = new int[n][];

Console.WriteLine("Заполните массив:");
for (int i = 0; i < n; i++) {
  array[i] = new int[n];
  for (int j = 0; j < n; j++) {
    Console.Write("array[{0}][{1}] = ", i, j);
    array[i][j] = int.Parse(Console.ReadLine());
  }
}

int[] x = new int[n];
Console.WriteLine("Заполните вектор X:");
for (int i = 0; i < n; i++) {
  Console.Write("x[{0}] = ", i);
  x[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i += 2) {
  array[i] = x;
}

for (int i = 0; i < n; i++) {
  for (int j = 0; j < n; j++) {
    Console.Write("{0}\t", array[i][j]);
  }
  Console.WriteLine();
}
