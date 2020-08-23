namespace TestInterviewAuto.Domain.Model.Color
{
    public class CarColor : Entity<long>, ICarColor
    {
        public string Name { get; }
        public string Hex { get; }

        public CarColor()
        {
            
        }
        public CarColor(string name, string hex) 
        {
            Name = name;
            Hex = hex;
        }
        
        public CarColor(long key,string name, string hex) : base(key)
        {
            Name = name;
            Hex = hex;
        }
    }
}