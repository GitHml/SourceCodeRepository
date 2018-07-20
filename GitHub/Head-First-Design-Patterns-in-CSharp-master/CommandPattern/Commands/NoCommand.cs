using CommandPattern.Abstractions;

namespace CommandPattern.Commands
{
    /// <summary>
    /// 它是一个空的类, 只是为了初始化command 以便以后不用判断是否为null.
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}