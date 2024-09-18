using System.ComponentModel.DataAnnotations.Schema;

namespace Blazorwebserverapp.Models
{
    public class GroupMessageTrack
    {
        public string Id { get; set; }
        public GroupMessage GroupMessage { get; set; }
        [ForeignKey(nameof(GroupMessage))]
        public string GroupMessageId { get; set; }
        public string RecievedUserId { get; set; }
        public DateTime RecievedDate { get; set; }
        public bool IsMessageDeleted { get; set; }
    }
}
