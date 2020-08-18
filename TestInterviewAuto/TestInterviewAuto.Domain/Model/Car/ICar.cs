using System;
using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Domain.Model.Car
{
    public interface ICar
    {
        long Key { get; }
        string RegistrationNumber { get; set; }
        long ColorId { get; set; }
        int YearOfIssue { get; }
        long CarBrandId { get; }
        CarBrand.CarBrand CarBrand { get; }
        CarColor Color { get; }
    }
}