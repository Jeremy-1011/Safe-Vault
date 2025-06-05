
using System.ComponentModel.DataAnnotations;

namespace SafeVault.Models
{
    public class VaultItem
    {
        public int Id { get; set; }

        [Required]
        public string Data { get; set; }

        public int UserId { get; set; }
    }
}
