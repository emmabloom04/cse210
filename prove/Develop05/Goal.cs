abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }
    public Goal()
    {

    }

    public string ObtainName()
    {
        Console.Write("Name of goal: ");
        _name = Console.ReadLine();
        return _name;
    }

    public string GetName()
    {
        return _name;
    }

    public string ObtainDescription()
    {
        Console.Write("Goal description: ");
        _description = Console.ReadLine();
        return _description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int ObtainPoints()
    {
        Console.Write("Number of points associated with goal: ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public int GetPoints()
    {
        return _points; 
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public virtual string ListGoal()
    {
        string complete;
        if (_status == false)
        {
            complete = "[ ]";
        }
        else
        {
            complete = "[X]";
        }
        return $"{complete} {_name} ({_description})";
    }

    public abstract string GetGoalType();

    public abstract int RecordEvent();

    public abstract void RunGoal();
}