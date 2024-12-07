public class MusicStation
{
    public bool IsTurnedOn { get; set; }
    public string Music { get; set; }

    public void Switch()
    {
        IsTurnedOn = !IsTurnedOn;
    }

    public void SetMusic(string music)
    {
        Music = music;
    }

    public override string ToString()
    {
        return $"Колонка: Включена - {IsTurnedOn}, Музыка - {Music}";
    }
}