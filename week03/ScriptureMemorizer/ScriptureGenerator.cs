using System;
using System.IO;
using System.Collections.Generic;

public class ScriptureGenerator
{    private string[] _scripturesArray;
 
    public ScriptureGenerator()
    {
        _scripturesArray = File.ReadAllLines("oldtestament.txt");
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int selector = random.Next(_scripturesArray.Length);

        string randomLine = _scripturesArray[selector];
        string[] parts = randomLine.Split("||");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int verse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        return scripture;
    }
}