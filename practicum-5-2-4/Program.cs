uint SumOfDigits(uint n) {
    uint result = 0;
    while (n > 0) {
        result += n % 10;
        n /= 10;
    }
    return result;
}

Console.Write("a = ");
uint a = uint.Parse(Console.ReadLine());

Console.Write("b = ");
uint b = uint.Parse(Console.ReadLine());

Console.Write("a) ");
for (uint i = a; i <= b; i++) {
    Console.Write("{0} ", SumOfDigits(i));
}
Console.WriteLine();

Console.Write("C = ");
uint C = uint.Parse(Console.ReadLine());
Console.Write("b) ");
for (uint i = a; i <= b; i++) {
    if (SumOfDigits(i) == C) {
        Console.Write("{0} ", i);
    }
}
Console.WriteLine();

Console.Write("c) ");
for (uint i = a; i <= b; i++) {
    if (SumOfDigits(i) % 2 == 1) {
        Console.Write("{0} ", i);
    }
}
Console.WriteLine();

Console.Write("A = ");
uint A = uint.Parse(Console.ReadLine());
uint currentNum = A;
uint sumA = SumOfDigits(A);

if (A < 10) {
    Console.WriteLine("d) not found");
} else {
    do {
        currentNum--;
    } while (SumOfDigits(currentNum) != sumA);
    Console.WriteLine("d) {0}", currentNum);
}
