using CommandPattern.Abstractions;

namespace CommandPattern.Commands
{
    /// <summary>
    /// ����һ���յ���, ֻ��Ϊ�˳�ʼ��command �Ա��Ժ����ж��Ƿ�Ϊnull.
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