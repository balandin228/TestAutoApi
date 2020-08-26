namespace TestInterviewAuto.Domain.Model.Brand
{
    public class Brand : Entity<long>
    {
        public string Name { get; }

        public Brand()
        {
            
        }
        public Brand(string name)
        {
            Name = name;
        }
    }
}