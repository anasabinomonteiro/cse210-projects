using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Separate text in words
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        /*** Strech challenge - Randomly select only the words that are not already hidden.***/

        //Create a class List to nonHidden words
        List<int> nonHiddenIndices = new List<int>();
        for (int i =0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                nonHiddenIndices.Add(i);
            }
        }

        //Verify that are sufficient words to hide
        if (nonHiddenIndices.Count < numberToHide)
        {
            Console.WriteLine("There's no sufficient words to hide");
            return;
        }

        //Hide ramdom words nonhide
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(nonHiddenIndices.Count);
            int wordIndex = nonHiddenIndices[randomIndex];
            _words[wordIndex].Hide();
            nonHiddenIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        //Verify if all the words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}




