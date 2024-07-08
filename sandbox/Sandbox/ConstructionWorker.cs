class ConstructionWorker : Employee {
    public ConstructionWorker(string name, double hoursWorked, double hourlyPay) : base(name, hoursWorked, hourlyPay) {

    }

    public override double GetPay() {
        return base.GetPay() + 1000;
    }
}