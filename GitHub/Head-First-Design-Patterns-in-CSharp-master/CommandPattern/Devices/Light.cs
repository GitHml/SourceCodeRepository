using System;

namespace CommandPattern.Devices
{
    /// <summary>
    /// Ò»ÕµµÆ
    /// </summary>
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}