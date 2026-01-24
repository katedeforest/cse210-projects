using System;
using System.IO;
using System.Collections.Generic;

public class Password
{
    private Dictionary<string, string> _journalPassword = new Dictionary<string, string>();
    private string _filename = "journalPassword.txt"; // store all passwords here

    public Password()
    {
        // Load existing passwords from file if it exists
        if (File.Exists(_filename))
        {
            string[] lines = File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("||");
                if (parts.Length == 2)
                {
                    _journalPassword[parts[0]] = parts[1];
                }
            }
        }
    }

    public void setPassword(string journal, string password)
    {
        // Add or update the password for the journal
        _journalPassword[journal] = password;

        // Save all passwords to file
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (var kvp in _journalPassword)
            {
                outputFile.WriteLine($"{kvp.Key}||{kvp.Value}");
            }
        }

        Console.WriteLine($"Password for {journal} saved.");
    }

    public bool checkExist(string journal)
    {
        return _journalPassword.ContainsKey(journal);
    }

    public bool verifyPassword(string journal, string password)
    {
        return _journalPassword.ContainsKey(journal) && _journalPassword[journal] == password;
    }
}