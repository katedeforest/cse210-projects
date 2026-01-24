using System;
using System.IO;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture (Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }        
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            Word wordToHide = visibleWords[randomIndex];

            wordToHide.Hide();

            visibleWords.RemoveAt(randomIndex);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            scriptureText += $"{word.GetDisplayText()} ";
        }
        return scriptureText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}