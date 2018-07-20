using CommandPattern.Abstractions;
using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    /// <summary>
    /// นุตฦ
    /// </summary>
    public class LightOffCommand: ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}