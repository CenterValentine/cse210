using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string some)
    {
        _word = some;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }

    public void Toggle()
    {
        if (_hidden == false)
        {
            _hidden = true;
        }
        else
        {
            _hidden = false;
        }
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord(bool hint = false)
    {
        Console.Write($" {_word}");
    }

}