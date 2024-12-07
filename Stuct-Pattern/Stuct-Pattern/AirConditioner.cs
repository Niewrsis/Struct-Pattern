public class AirConditioner
{
    public bool IsTurnedOn { get; set; }
    public int Temperature { get; set; }

    public void Switch()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
    }

    public override string ToString()
    {
        return $"Кондиционер: Включен - {IsTurnedOn}, Температура - {Temperature}";
    }
}