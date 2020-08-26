﻿using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Domain.Model.Car
{
    public class Car : Entity<long>, ICar
    {
        public string RegistrationNumber { get; set; }
        public long ColorId { get; set; }
        public int YearOfIssue { get; }
        public long CarBrandId { get; }
        public virtual Brand.Brand Brand { get; }
        public virtual Color.Color Color { get; }

        public Car()
        {
            
        }
        public Car(string registrationNumber, long colorId, int yearOfIssue, long carBrandId)
        {
            CarBrandId = carBrandId;
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
            ColorId = colorId;
        }
        
        public Car(long key,string registrationNumber, long colorId, int yearOfIssue, long carBrandId):base(key)
        {
            CarBrandId = carBrandId;
            YearOfIssue = yearOfIssue;
            RegistrationNumber = registrationNumber;
            ColorId = colorId;
        }
    }
}