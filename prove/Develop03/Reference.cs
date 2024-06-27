using System;

// Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
public class Reference
{
    private string _book;
    private string _chapter;

    private string _verse;

    private string _endVerse;

    // private List<Word> _verses;
    Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }



}