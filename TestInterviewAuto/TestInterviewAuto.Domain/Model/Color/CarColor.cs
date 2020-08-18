namespace TestInterviewAuto.Domain.Model.Color
{
    public class CarColor : Entity<long>, ICarColor
    {
        public string Name { get; }
        public string Hex { get; }

        public CarColor(string name, string hex)
        {
            Name = name;
            Hex = hex;
        }
    }
}