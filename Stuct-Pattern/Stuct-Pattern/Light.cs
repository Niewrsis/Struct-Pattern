public class Light
{
    public bool IsTurnedOn { get; set; }
    public int Brightness { get; set; }
    public string Color { get; set; }

    public void SwitchLight()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void ChangeBrightness(int brightness)
    {
        Brightness = brightness;
    }

    public void ChangeColor(string color)
    {
        Color = color;
    }

    public override string ToString()
    {
        return $"Свет: Включен - {IsTurnedOn}, Яркость - {Brightness}, Цвет - {Color}";
    }
}