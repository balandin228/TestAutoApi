namespace TestInterviewAuto.Domain.Model.Color
{
    public class Color : Entity<long>
    {
        public string Name { get; private set; }
        public string Hex { get; private set; }

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