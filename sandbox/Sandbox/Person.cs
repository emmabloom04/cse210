class Person {
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight) {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
        // could use this.firstName = firstName; as 'this' refers to the class you're in (variable names have to match tho, w/o underscores)
    }

    public string PersonInformation() {
        return $"{_firstName} {_lastName}, {_age}, {_weight}";
    }
}