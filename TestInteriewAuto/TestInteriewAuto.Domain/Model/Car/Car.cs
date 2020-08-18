using TestInteriewAuto.Domain.Model.Color;

namespace TestInteriewAuto.Domain.Model.Car
{
    public class Car : Entity<long>, ICar
    {
        public string RegistrationNumber { get; set; }
        public long ColorId { get; set; }
        public int YearOfIssue { get; }
        public long CarBrandId { get; }
        public virtual CarBrand.CarBrand CarBrand { get; }
        public virtual CarColor Color { get; }

        public Car(string registrationNumber, long colorId, int yearOfIssue, long carBrandId)
        {
            CarBrandId = carBrandId;
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
            ColorId = colorId;
        }
    }
}