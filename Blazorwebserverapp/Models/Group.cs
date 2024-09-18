using System.ComponentModel.DataAnnotations;

namespace Blazorwebserverapp.Models
{
    public class Group
    {
        [Key]
        public string GroupId { get; set; }
       
        public string GroupName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; }
        public string GroupDescription { get; set; }        
        public string GroupIcon { get; set; }
        public bool IsDeleted { get; set; }
     
    }
}
