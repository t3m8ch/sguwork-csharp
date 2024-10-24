Console.Write("Введите размер массива n = ");
uint n = uint.Parse(Console.ReadLine());

int[][] array = new int[n*2][];

Console.WriteLine("Заполните массив:");
for (int i = 0; i < n; i++) {
  array[i] = new int[n];
  for (int j = 0; j < n; j++) {
    Console.Write("array[col: {0}][row: {1}] = ", i, j);
    array[i][j] = int.Parse(Console.ReadLine());
  }
}

Console.Write("Укажите число = ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) {
  for (int j = 0; j < n; j++) {
    Console.Write("{0}\t", array[j][i]);
  }
  Console.WriteLine();
}
