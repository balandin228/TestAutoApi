using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterviewAuto.Web.Dtos
{
    public class CreateCarDto
    {
        public string RegistrationNumber { get; set; }
        [Required]
        public long ColorId { get; set; }
        [Required]
        public int YearOfIssue { get; set; }
        [Required]
        public long CarBrandId { get; set; }
    }
}
