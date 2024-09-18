using Blazorwebserverapp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazorwebserverapp.Models
{
    public class GroupMember
    {
        [Key]
        public int Id { get; set; }
        public Group Group { get; set; }

        [ForeignKey(nameof(Group))]
        public string GroupId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string UserId { get; set; }
    }
}
