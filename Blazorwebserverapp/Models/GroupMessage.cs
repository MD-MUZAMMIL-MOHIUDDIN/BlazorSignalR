using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazorwebserverapp.Models
{
    public class GroupMessage
    {
        [Key]
        public string GroupMessageId { get; set; }
        public string FromId { get; set; }
        //public string SendToId { get; set; }
        public Group Group { get; set; }
        [ForeignKey(nameof(Group))]
        public string GroupId { get; set; }
        public string Message { get; set; }
       // public DateTime RecievedDate { get; set; }
        //public DateTime SeenDate { get; set; }
        public DateTime SendDate { get; set; }
        //public bool IsBlocked { get; set; }
        //public string BlockedBy { get; set; }
        //public bool IsLeft { get; set; }
    }
}
