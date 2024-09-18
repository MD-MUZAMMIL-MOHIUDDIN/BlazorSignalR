using System.ComponentModel.DataAnnotations;

namespace Blazorwebserverapp.Models
{
    public class Conversation
    {
        [Key]
        public int Id { get; set; }
        public string FromId { get; set; }
        public string SendToId { get; set; }
        public string Message { get; set; }
        public DateTime RecievedDate { get; set; }
        public DateTime SeenDate { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsBlocked { get; set; }
        public string BlockedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
