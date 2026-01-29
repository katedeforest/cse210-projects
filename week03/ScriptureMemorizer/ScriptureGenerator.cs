using System;
using System.IO;
using System.Collections.Generic;

public class ScriptureGenerator
{
    private string[] scripturesArray;
    public ScriptureGenerator()
    {
        scripturesArray = File.ReadAllLines("oldtestament.cs");
    }

    public Scripture getRandomScripture()
    {
        string[] scriptures = File.ReadAllLines("oldtestament.cs");

        foreach (string item in scripturesArray)
            {
                string[] parts = item.Split("||");

                Reference reference = new Reference(parts[0], parts[1], parts[2], parts[3]);

                _entries.Add(entry);
            }
    }

    

}