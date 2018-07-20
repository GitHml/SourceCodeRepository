using CommandPattern.Abstractions;
using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    /// <summary>
    /// ���Ƶƴ򿪵�����
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}