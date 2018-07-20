namespace CommandPattern.Devices
{
    /// <summary>
    /// “ÙœÏ
    /// </summary>
    public class Stereo
    {

        public Stereo()
        {
            Volume = 5;
        }

        public void On()
        {
            System.Console.WriteLine("Stereo is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("Stereo is off.");
        }

        public void SetCD()
        {
            System.Console.WriteLine("Stereo is set for CD input.");
        }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                System.Console.WriteLine($"Stereo's volume is set to {volume}");
            }
        }

    }
}