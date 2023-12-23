

namespace CountLetters;

public class CheckLetters
{
    private string _word;
    private char _target;
     

    public CheckLetters(string word, char target)
    {
        _word = word;
        _target = target;
    }

    public int GetCount()
    {
        int count = 0;
        foreach (char letter in _word)
        {
            if (letter == _target)
            {
                count++;
            }
        }

        return count;
    }
}