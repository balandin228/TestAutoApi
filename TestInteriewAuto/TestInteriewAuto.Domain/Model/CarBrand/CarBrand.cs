namespace TestInteriewAuto.Domain.Model.CarBrand
{
    public class CarBrand : Entity<long> ,ICarBrand
    {
        public string Name { get; }

        public CarBrand(string name)
        {
            Name = name;
        }
    }
}