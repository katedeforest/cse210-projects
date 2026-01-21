using System;
using System.IO;
using System.Collections.Generic;

public class Password
{
    Dictionary<string, string> _journalPassword = new Dictionary<string, string>();

    
    public void setPassword(string journal, string password) // takes journal and password, no return
    {
        // add a journal:password to dictionary
        _journalPassword.Add(journal, password);

        string filename = "journalPassword.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_journalPassword);
        }

        Console.WriteLine($"Password for {journal} saved.");
    }
    
    public bool checkExist(string journal)// takes journal, returns true or false
    {
        // load passwords
        

        // check for existing journal in dictionary
        if (journalPassword.ContainsKey(journal))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    
    public bool verifyPassword(string journal, string password) // takes journal and password, returns true or false
    {
        // check for matching journal:password pair in dictionary
        if (journalPassword.ContainsKey(journal) && journalPassword[journal] == password)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}