using System.ComponentModel.DataAnnotations;

namespace Blazorwebserverapp.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
