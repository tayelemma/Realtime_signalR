﻿namespace Realtime_signalR.Models
{
    public class User
    {
        public Guid userId { get; set; }
        public string userName { get; set; } = string.Empty;
        public string userEmail { get; set; } = string.Empty;
        public string userPassword { get; set; } = string.Empty;
        public string userImage { get; set; } = string.Empty;
    }
}
