uint greatestCommonDivisor(uint a, uint b) {
    if (a == b) {
        return a;
    }

    if (a > b) {
        return greatestCommonDivisor(a - b, b);
    }

    return greatestCommonDivisor(a, b - a);
}

Console.Write("a = ");
uint a = uint.Parse(Console.ReadLine());

Console.Write("b = ");
uint b = uint.Parse(Console.ReadLine());

Console.WriteLine("НОД = {0}", greatestCommonDivisor(a, b));
