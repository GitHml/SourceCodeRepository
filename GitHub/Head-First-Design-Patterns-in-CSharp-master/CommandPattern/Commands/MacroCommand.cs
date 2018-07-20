using CommandPattern.Abstractions;

namespace CommandPattern.Commands
{
    /// <summary>
    /// 一个按钮控制多个设备的多个动作
    /// Party Mode (聚会模式):
    /// </summary>
    public class MacroCommand : ICommand
    {
        private ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Undo();
            }
        }
    }
}