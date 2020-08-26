using System.Collections.Generic;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Domain.Model.Car
{
    public class Car : Entity<long>
    {
        public string RegistrationNumber { get; set; }
        public long ColorId { get; set; }
        public int YearOfIssue { get; }
        public long CarBrandId { get; }
        public virtual List<CarColor.CarColor> CarColors { get; }
        public virtual Color.Color Color { get; }

        public Car()
        {
            CarColors = new List<CarColor.CarColor>();
        }
        public Car(string registrationNumber, long colorId, int yearOfIssue, long carBrandId)
        {
            CarColors = new List<CarColor.CarColor>();
            CarBrandId = carBrandId;
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
            ColorId = colorId;
        }
        
        public Car(long key,string registrationNumber, long colorId, int yearOfIssue, long carBrandId):base(key)
        {
            CarColors = new List<CarColor.CarColor>();
            CarBrandId = carBrandId;
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
            ColorId = colorId;
        }
    }
}