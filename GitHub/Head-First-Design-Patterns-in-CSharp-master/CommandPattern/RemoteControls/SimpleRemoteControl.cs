using CommandPattern.Abstractions;

namespace CommandPattern.RemoteControls
{
    /// <summary>
    /// ¼òÒ×µÄÒ£¿ØÆ÷
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