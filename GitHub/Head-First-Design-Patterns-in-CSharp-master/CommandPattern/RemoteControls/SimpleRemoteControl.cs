using CommandPattern.Abstractions;

namespace CommandPattern.RemoteControls
{
    /// <summary>
    /// ���׵�ң����
    /// </summary>
    public class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public SimpleRemoteControl()
        {

        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}