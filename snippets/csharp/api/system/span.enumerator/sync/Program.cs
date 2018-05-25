﻿using System;
using System.Threading;

class Program
{
    private static readonly byte[] _array = new byte[5];

    static void Main()
    {
        new Random(42).NextBytes(_array);
        Span<byte> span = _array;

        Thread thread = new Thread(delegate ()
        {
           ClearContents();
        });

        thread.Start();

        EnumerateSpan(span);
    }

    public static void ClearContents()
    {
        Thread.Sleep(20);
        lock (_array)
        {
           Array.Clear(_array, 0, _array.Length);
        }
    }

    // <Snippet1>
    public static void EnumerateSpan(Span<byte> span)
    {
        lock (_array)
        {
            foreach (byte element in span)
            {
                Console.WriteLine(element);
                Thread.Sleep(10);
            }
        }
    }
    // The example displays the following output:
    //    62
    //    23
    //    186
    //    150
    //    174
    // </Snippet1>
}
