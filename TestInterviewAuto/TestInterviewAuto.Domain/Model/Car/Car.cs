using System.Collections.Generic;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Domain.Model.Car
{
    public class Car : Entity<long>
    {
        public string RegistrationNumber { get; set; }
        public int YearOfIssue { get; }
        public virtual CarColor.CarColor CarColor { get; }
        public virtual CarBrand.CarBrand CarBrand { get; }

        public Car()
        {
        }
        public Car(string registrationNumber, int yearOfIssue)
        {
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
        }
        
        public Car(long key,string registrationNumber, long carColorId, int yearOfIssue, long carBrandId):base(key)
        {
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
        }
    }
}