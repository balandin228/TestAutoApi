namespace TestInterviewAuto.Domain.Model.CarBrand
{
    public class CarBrand : Entity<long> ,ICarBrand
    {
        public string Name { get; }

        public CarBrand()
        {
            
        }
        public CarBrand(string name)
        {
            Name = name;
        }
    }
}