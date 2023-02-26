namespace DependencyInjectAndOptionPatter.AutoFac
{
    public class EmailService : IMessageService
    {
        public string SendMessage(string message)
        {
            return $"Email-Message: {message}";
        }
    }
}
