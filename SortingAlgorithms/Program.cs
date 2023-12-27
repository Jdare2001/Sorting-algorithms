// See https://aka.ms/new-console-template for more information

using System;



public class Sorter{

    
    public static void Main(string[] args){
        BubbleSort bubbleSort = new BubbleSort();
        Random numberGen = new Random();
        Console.WriteLine("bubble sorter");
        int[] ints = new int[6];
        for(int i = 0; i < ints.Length; i++){
            ints[i] = numberGen.Next(10);
        }
        Console.WriteLine("[{0}]", string.Join(", ", ints));
        Console.WriteLine("Sorting");
        int[] sortedArray = new int[6];
        sortedArray = bubbleSort.AscendingSort(ints);
        Console.WriteLine("[{0}]", string.Join(", ", sortedArray));


    }

    
}

