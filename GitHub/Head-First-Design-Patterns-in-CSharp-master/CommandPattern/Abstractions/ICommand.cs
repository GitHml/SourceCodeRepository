namespace CommandPattern.Abstractions
{
    /// <summary>
    /// �������ģʽ
    /// �������������Ҫʵ�ֵĽӿ�
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}