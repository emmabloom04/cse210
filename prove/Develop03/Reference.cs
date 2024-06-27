class Reference {

    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse.ToString();
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = $"{startVerse}-{endVerse}";
    }

    public string GetScriptureReference() {
        return $"{_book} {_chapter}:{_verse}";
    }

    public void ShowScriptureReference() {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }

}