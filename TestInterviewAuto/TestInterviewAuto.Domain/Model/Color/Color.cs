namespace TestInterviewAuto.Domain.Model.Color
{
    public class Color : Entity<long>, IColor
    {
        public string Name { get; }
        public string Hex { get; }

        public Color()
        {
            
        }
        public Color(string name, string hex) 
        {
            Name = name;
            Hex = hex;
        }
        
        public Color(long key,string name, string hex) : base(key)
        {
            Name = name;
            Hex = hex;
        }
    }
}