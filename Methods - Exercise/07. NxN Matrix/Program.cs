﻿int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        MatrixSize(n);
    }
    Console.WriteLine();
}

static void MatrixSize(int n)
{
    Console.Write(n + " ");
}
