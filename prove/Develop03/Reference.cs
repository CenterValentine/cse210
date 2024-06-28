using System;


public class Reference
{
    private string _book;
    private string _chapter;

    private string _verse;

    private string _endVerse;

    // Splits single argument reference into components
    private void StoreReference(string referenceText)
    {
        string[] referenceBookChaptVerse = referenceText.Split(' ');
        string[] referenceChaptVerse = referenceBookChaptVerse[1].Split(':');
        string[] referenceVerseVerses = referenceChaptVerse[1].Split('-');
        string[] reference = [referenceBookChaptVerse[0], referenceChaptVerse[0], referenceVerseVerses[0]];
        _book = reference[0];
        _chapter = reference[1];
        _verse = reference[2];
        if (referenceVerseVerses.Length > 1)
        {
            _endVerse = reference[1];
        }



    }
    // private List<Word> _verses;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string referenceText)
    {
        StoreReference(referenceText);

    }


    public Reference(string referenceText, string referenceContent)
    {
        StoreReference(referenceText);
    }


    public void DisplayAll()
    {
        if (_endVerse != null)
        {
            Console.Write(_book + " " + _chapter + ":" + _verse + "-" + _endVerse);
        }
        else
        {
            Console.Write(_book + " " + _chapter + ":" + _verse);
        }
    }

}