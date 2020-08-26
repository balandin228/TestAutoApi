using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterviewAuto.Domain.Model.CarBrand
{
    public class CarBrand : Entity<long>
    {
        public long BrandId { get; }
        public long CarId { get; }
        public virtual  Car.Car Car { get; }
        public virtual Brand.Brand Brand { get; }

        public CarBrand()
        {
        }

        public CarBrand(long brandId, long carId)
        {
            BrandId = brandId;
            CarId = carId;
        }

        public CarBrand(long key, long brandId, long carId) : base(key)
        {
            BrandId = brandId;
            CarId = carId;
        }
    }
}
