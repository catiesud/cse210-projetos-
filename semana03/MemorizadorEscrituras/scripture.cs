using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = text
            .Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words
            .Where(word => !word.IsHidden())
            .ToList();

        if (visibleWords.Count == 0)
        {
            return;
        }

        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return $"{_reference.GetDisplayText()}\n{text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}