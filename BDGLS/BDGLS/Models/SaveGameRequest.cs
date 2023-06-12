using System.ComponentModel.DataAnnotations;

namespace BDGLS.Models
{
    public class SaveGameRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "File is required")]
        public byte[] File { get; set; }
    }
}