using System;

class Test { 
    static void Main() { 
        Console.WriteLine (OneMethod (3)); 
        Console.WriteLine (OneMethod (1)); 
    }
    static int OneMethod (int feet) 
    { 
        int inches = feet * 2; 
        return inches; 
    } 
}