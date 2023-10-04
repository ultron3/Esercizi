// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;

public  class Program
{
    public static void Main(string[]args)
    {
        // Creiamo due oggetti Thread e assegnamo loro due metodi diversi da eseguire
        Thread threadFirst = new Thread(MethodFirst);
        Thread threadSecond = new Thread(MethodSecond);

        // Avviamo i due thread
        threadFirst.Start();
        threadSecond.Start();

        // Attendiamo che entrambi i thread terminino prima di proseguire
        threadFirst.Join();
        threadSecond.Join();

        Console.WriteLine("Both threads have completed execution.");
    }

    static void MethodFirst()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Method1: Iteration " + i);
            Thread.Sleep(100); // Aggiungiamo una breve pausa per simulare un lavoro
        }
    }

    static void MethodSecond()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("Method2: Iteration " + i);
            Thread.Sleep(150); // Aggiungiamo una breve pausa per simulare un lavoro diverso
            i++;
        }

    }
}
