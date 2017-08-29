namespace Fiver.Asp.Middleware.Options
{
    public enum MessageFormat { None, Upper, Lower}

    public class MessageService : IMessageService
    {
        private readonly MessageOptions options;

        public MessageService(MessageOptions options)
        {
            this.options = options;
        }

        public string FormatMessage(string message)
        {
            // use options
            return this.options.Format == MessageFormat.None ? message :
                    this.options.Format == MessageFormat.Upper ? message.ToUpper() :
                     message.ToLower();
        }
    }
}
