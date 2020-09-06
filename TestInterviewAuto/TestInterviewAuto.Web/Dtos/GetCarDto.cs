using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterviewAuto.Web.Dtos
{
    public class GetCarDto
    {
        public string RegistrationNumber { get; set; }
        public int YearOfIssue { get; set; }
        public GetColorDto Color { get; set; }
        public GetBrandDto Brand { get; set; }
    }
}
