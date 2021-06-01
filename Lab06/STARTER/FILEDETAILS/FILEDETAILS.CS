

using System;                
using System.IO;             
    
class FileDetails 
{
    static void Summarize(char[ ] contents)
    {
        int vowels = 0, consonants = 0, lines = 0;
        foreach (char current in contents) 
        {
            if (Char.IsLetter(current)) 
            {
                if ("AEIOUaeiou".IndexOf(current) != -1) 
                {
                vowels++;
                } else {
                consonants++;
            }
        }
        else if (current == '\n') {
        lines++;
      }
    }
        Console.WriteLine("Total no of characters: {0}", contents.Length);
        Console.WriteLine("Total no of vowels : {0}", vowels);
        Console.WriteLine("Total no of consonants: {0}", consonants);
        Console.WriteLine("Total no of lines : {0}", lines);
    }
}
