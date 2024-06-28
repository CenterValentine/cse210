using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private void ScriptureWords(string[] words)
    {
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        //Convert content to Word objects;
        ScriptureWords(words);
    }

    public void DisplayReference()
    {
        _reference.DisplayAll();
    }

    // Log all words in Scripture.

    // Randomly hide 1-3 _words of Scripture.
    private void HideRandomWord()
    {

        int hiddenWordsCount = 0;
        hiddenWordsCount++;


        Random random = new Random();
        int randomWHideCount = random.Next(1, 4);
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            { unhiddenWords.Add(word); }
        }
        // Hides unhidden words
        for (int i = 0; i < randomWHideCount; i++)
        {
            int index = random.Next(unhiddenWords.Count);

            DetectEndProgram(unhiddenWords.Count, _words.Count);
            Console.WriteLine($"unhiddenWordsCount: {unhiddenWords.Count}");
            unhiddenWords[index].Hide();
        }
        //  Simple Version
        // {
        //     int index = random.Next(_words.Count);
        //     _words[index].Hide();
        // }
    }

    //  Provides one word that has been hidden. 
    public void Hint()
    {
        Random random = new Random();
        bool isHidden = false;
        while (!isHidden)
        {
            int index = random.Next(_words.Count);
            if (_words[index].IsHidden())
            {
                isHidden = true;
                _words[index].DisplayWord();
                break;
            }
        }
    }

    public void DisplayAll()
    {
        DisplayReference();
        Console.WriteLine("\n");
        // Iterate all _words in scripture  // If word is hidden then display a blank line of equal length.
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                string blankLine = " ";
                for (int i = 0; i < word.GetWord().Length; i++)
                { blankLine += "_"; }
                Console.Write($"{blankLine} ");
            }
            else
            {
                word.DisplayWord();
            }


        }
        // Console.WriteLine('\n');
        HideRandomWord();
    }

    private static void DetectEndProgram(int start, int finish)
    {
        if (start < 1)
        {
            Console.WriteLine("\n\nWe've blanked out all the words! ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nMe thinks you have this memorized!\n");
            Console.WriteLine("Nice job. Goodbye!\n");
            Environment.Exit(0);
        }

    }
}