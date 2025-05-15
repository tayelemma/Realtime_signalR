namespace Realtime_signalR.Models
{
    public class Message
    {
        public int messageId { get; set; }
        public string messageText { get; set; } = string.Empty;
        public DateTime messageDate { get; set; }
        public string messageTime { get; set; } = string.Empty;
        public string messageImage { get; set; } = string.Empty;

    }
}
