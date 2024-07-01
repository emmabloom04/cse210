class Policeman : Person {
    private string _weapons;

    public Policeman(string weapons, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight) {
        _weapons = weapons;
    }

    public Policeman() : base("", "", 0, 0) {
        _weapons = "";
    }
    // a way to make a default constructor

    public string PolicemanInformation() {
        return $"{_weapons}, {PersonInformation()}";
    }
}