using System.ComponentModel.DataAnnotations;

namespace TestInterviewAuto.Web.Dtos
{
    public class CreateColorDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Hex { get; set; }
    }
}