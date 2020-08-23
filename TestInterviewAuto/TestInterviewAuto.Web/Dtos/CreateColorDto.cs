using System.ComponentModel.DataAnnotations;

namespace TestInterviewAuto.Web.Dtos
{
    public class CreateColorDto
    {
        [Required]
        public string Name { get; }
        [Required]
        public string Hex { get; }
    }
}