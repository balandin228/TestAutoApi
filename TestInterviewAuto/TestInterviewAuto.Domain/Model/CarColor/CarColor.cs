using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterviewAuto.Domain.Model.CarColor
{
    public class CarColor : Entity<long>
    {
        public long CarId { get; }
        public long ColorId { get; }
        public virtual Car.Car Car { get; }
        public virtual Color.Color Color { get; }
        public CarColor()
        {
        }

        public CarColor(long carId, long colorId)
        {
            CarId = carId;
            ColorId = colorId;
        }

        public CarColor(long key, long carId, long colorId) : base(key)
        {
            CarId = carId;
            ColorId = colorId;
        }
    }
}
