using CommandPattern.Abstractions;

namespace CommandPattern.Commands
{
    /// <summary>
    /// һ����ť���ƶ���豸�Ķ������
    /// Party Mode (�ۻ�ģʽ):
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