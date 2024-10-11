void printNums(uint curr, uint n) {
    for (uint i = 0; i < curr; i++) {
        Console.Write("{0}\t", curr);
    }

    Console.WriteLine();

    if (curr != n) {
        printNums(curr + 1, n);
    }
}

Console.Write("n = ");
uint n = uint.Parse(Console.ReadLine());
printNums(1, n);
