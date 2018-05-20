using System;
using System.Diagnostics;
public class Helper
{
    public static int[] InputList {get{return new int[]{41,62,33,24,75,16,57,89,98};}}

    public static void Watch(Func<int[],int[]> func){
        Stopwatch sw = new Stopwatch();
        sw.Start();
        var output = func.Invoke(InputList);
        sw.Stop();
        Console.Write($"Function: {func.Method.Name}, Time: {sw.Elapsed} output: ");
        foreach(var item in output){
            Console.Write(item+"  ");
        }
        Console.WriteLine();
    }
}