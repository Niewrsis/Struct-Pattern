public class SmartHome
{
    private Light light;
    private TV tv;
    private AirConditioner airConditioner;
    private MusicStation musicStation;

    public SmartHome()
    {
        light = new Light();
        tv = new TV();
        airConditioner = new AirConditioner();
        musicStation = new MusicStation();
    }

    public void SetUpHome(string mode)
    {
        switch (mode.ToLower())
        {
            case "ночной":
                light.SwitchLight();
                tv.SwitchTV();
                airConditioner.Switch();
                airConditioner.SetTemperature(20);
                musicStation.Switch();
                break;
            case "вечеринка":
                light.SwitchLight();
                light.ChangeColor("ярко-синий");
                light.ChangeBrightness(100);
                tv.SwitchTV();
                tv.TurnOnProgram("Музыкальный канал");
                airConditioner.SetTemperature(24);
                musicStation.Switch();
                musicStation.SetMusic("Dance music");
                break;
            case "доброе утро":
                light.SwitchLight();
                light.ChangeColor("теплый белый");
                light.ChangeBrightness(50);
                tv.SwitchTV();
                airConditioner.SetTemperature(22);
                musicStation.Switch();
                musicStation.SetMusic("Позитивная музыка");
                break;
            case "собираюсь на пары":
                light.SwitchLight();
                light.ChangeBrightness(70);
                tv.SwitchTV();
                airConditioner.SetTemperature(22);
                musicStation.Switch();
                break;

            case "ухожу":
                light.SwitchLight();
                tv.SwitchTV();
                airConditioner.Switch();
                musicStation.Switch();
                break;
            case "один дома":
                light.SwitchLight();
                light.ChangeBrightness(30);
                tv.SwitchTV();
                airConditioner.SetTemperature(22);
                musicStation.Switch();
                musicStation.SetMusic("Lofi Hip Hop");
                break;
            default:
                Console.WriteLine("Неизвестный режим.");
                break;
        }

        Console.WriteLine(light);
        Console.WriteLine(tv);
        Console.WriteLine(airConditioner);
        Console.WriteLine(musicStation);
    }
}