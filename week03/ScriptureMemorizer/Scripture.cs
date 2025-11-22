using System;
using System.Collections.Generic;

public class Scripture
{
    // member variables
    private Reference _reference;
    private List<Word> _words;

    // constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitwords = text.Split(" ");

        foreach (string w in splitwords)
        {
            _words.Add(new Word(w));
        }
    }

    // behaviors
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> displayWords = new List<string>();

        foreach (Word w in _words)
        {
            displayWords.Add(w.GetDisplayText());
        }
        return referenceText + "\n" + string.Join(" ", displayWords);
    }
    public bool isCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.isHidden())
                return false;
        }
        return true;

    }
}