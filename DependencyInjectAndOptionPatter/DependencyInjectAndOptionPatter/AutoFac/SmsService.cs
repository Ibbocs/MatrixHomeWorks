namespace DependencyInjectAndOptionPatter.AutoFac
{
    public class SmsService : IMessageService
    {
        public string SendMessage(string message)
        {
            return $"Sms-Message: {message}";
        }
    }
}
