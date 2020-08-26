using System.Collections.Generic;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Domain.Model.Car
{
    public class Car : Entity<long>
    {
        public string RegistrationNumber { get; set; }
        public int YearOfIssue { get; }
        public virtual List<CarColor.CarColor> CarColors { get; }
        public virtual List<CarBrand.CarBrand> CarBrands { get; }

        public Car()
        {
            CarColors = new List<CarColor.CarColor>();
            CarBrands = new List<CarBrand.CarBrand>();
        }
        public Car(string registrationNumber, int yearOfIssue)
        {
            CarColors = new List<CarColor.CarColor>();
            CarBrands = new List<CarBrand.CarBrand>();
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
        }
        
        public Car(long key,string registrationNumber, long carColorId, int yearOfIssue, long carBrandId):base(key)
        {
            CarColors = new List<CarColor.CarColor>();
            CarBrands = new List<CarBrand.CarBrand>();
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
        }
    }
}