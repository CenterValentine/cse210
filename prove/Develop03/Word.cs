using System;

public class Word
{
    private string _word;
    private bool _hidden;

    Word(string some, bool hidden)
    {
        _word = some;
        _hidden = hidden;
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
        if (_hidden == false) {
            _hidden = true;
        }
        else {
            _hidden = false;
        }
    }

    public bool IsHidden()
    {
        return _hidden;
    }

}