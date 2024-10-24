void f(uint start, uint n) {
  for (uint i = 1; i <= start; i++) {
    Console.Write("{0}\t", i);
  }
  Console.WriteLine();

  if (start < n) {
    f(start + 1, n);
  }
}

Console.Write("n = ");
uint n = uint.Parse(Console.ReadLine());

f(1, n);
