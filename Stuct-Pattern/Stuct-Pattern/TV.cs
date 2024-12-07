public class TV
{
    public bool IsTurnedOn { get; set; }
    public string Program { get; set; }

    public void SwitchTV()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void TurnOnProgram(string program)
    {
        Program = program;
    }

    public override string ToString()
    {
        return $"Телевизор: Включен - {IsTurnedOn}, Программа - {Program}";
    }
}
