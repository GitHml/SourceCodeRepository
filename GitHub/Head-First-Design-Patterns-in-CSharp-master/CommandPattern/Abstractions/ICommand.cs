namespace CommandPattern.Abstractions
{
    /// <summary>
    /// 命令设计模式
    /// 所有命令对象需要实现的接口
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}