class Word {

    string _word;

    public Word() {
        _word = "";
    }
    
    public Word(string word) {
        _word = word;
    }

    public string HideWord(string word) {
        int length = word.Length;
        string underscores = new string('_', length);
        return underscores;
    }
}