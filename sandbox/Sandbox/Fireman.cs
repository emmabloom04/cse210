class Fireman : Person {
    private string _certifications;

    public Fireman(string certifications, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight) {
        _certifications = certifications;
    }

    public Fireman() : base("", "", 0, 0) {
        _certifications = "";
    }
    // a way to make a default constructor

    public string FiremanInformation() {
        return $"{_certifications}, {PersonInformation()}";
    }
}