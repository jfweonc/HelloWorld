using System;

public static int add (params int[] list)
{
    int sum = 0; 
    for(int i = 0; i < list.Length; i++)
    {
        sum = sum + list[i];
    }
}
Console.WriteLine({ 1,2,3}); 