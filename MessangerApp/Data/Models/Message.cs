using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Message
    {
        public Message() { }

        public Message(string text, User user, Chat chat)
        {
            Id = Guid.NewGuid();
            Text = text;
            SandDate = DateTime.Now;
            User = user;
            Chat = chat;
            IsDeleted = false;
        }

        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ChatId { get; set; }

        public string Text { get; set; } = string.Empty;

        public DateTime SandDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Chat Chat { get; set; } = null!;
    }
}
