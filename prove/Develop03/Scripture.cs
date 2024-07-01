using System.Drawing;

class Scripture {

    List<string> _words = new List<string>();
    string _reference;
    List<int> _numbers = new List<int>();

    public Scripture(string book, int chapter, int verse, string text) {
        _reference = $"{book} {chapter}:{verse}";
        foreach (string word in text.Split(" ")) {
            _words.Add(word);
        }
        int length = GetListLength();
        List<int> numbers = new List<int>();
        for (int i = 0; i < length; i++) {
            numbers.Add(i);
        }
        _numbers = numbers;

    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text) {
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";
        foreach (string word in text.Split(" ")) {
            _words.Add(word);
        }
        int length = GetListLength();
        List<int> numbers = new List<int>();
        for (int i = 0; i < length; i++) {
            numbers.Add(i);
        }
        _numbers = numbers;
    }

    public Scripture(string reference, string text) {
        _reference = reference;
        foreach (string word in text.Split(" ")) {
            _words.Add(word);
        }
        int length = GetListLength();
        List<int> numbers = new List<int>();
        for (int i = 0; i < length; i++) {
            numbers.Add(i);
        }
        _numbers = numbers;
    }

    public void DisplayScripture() {
        Console.Clear();
        Console.WriteLine("Press ENTER to continue or type 'q' to quit.");
        Console.WriteLine(_reference);
        foreach (string word in _words) {
            Console.Write($"{word} ");
        }
    }

    public List<string> PickRandomWords() {
        int listLength = _numbers.Count;
        int numberOfWords;

        if (listLength >= 5) {
            numberOfWords = 5;
        }
        else {
            numberOfWords = listLength;
        }

        for (int i = 0; i < numberOfWords; i++) {
                Random randomGenerator = new Random();
                int index = randomGenerator.Next(_numbers.Count);
                    Word wordChanger = new Word();
                    int wordToRemove = _numbers[index];
                    _words[wordToRemove] = wordChanger.HideWord(_words[wordToRemove]);
                    _numbers.Remove(_numbers[index]);
            }
        
        return _words;
    }

    public int GetListLength() {
        int length = _words.Count;
        return length;
    }

    public bool AllFinished() {
        bool finished;
        foreach (string word in _words) {
            if (word[0] != '_') {
                finished = false;
                return finished;
            }
        }
        finished = true;
        return finished;
    }

}