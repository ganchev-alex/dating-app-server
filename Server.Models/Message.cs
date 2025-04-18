﻿namespace Server.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public User Sender { get; set; }
        public Guid RecipientId { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool IsDeletedBySender { get; set; }
    }
}
