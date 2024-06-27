class Scripture {

    List<string> _words = new List<string>();
    string _reference;

    public Scripture(string book, int chapter, int verse, string text) {
        _reference = $"{book} {chapter}:{verse}";
        // add something for the text
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse) {
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";
        // add something for the text
    }

    public Scripture(string reference, string text) {
        _reference = reference;
        // add something for the text
    }
    // words list<word>
    // reference: Reference class
    // scripture(name, chapter, verse, text)
    // scripture(name, chapter, start, end, text)
    // scripture(reference, text)

    // get methods from slides


    // foreach(string word in text.Split(" "))
    // Word tempWord = new Word(word);
    // _words.Add(tempWord);
    // tempWord.SetIsHidden(false);
}