namespace TestInterviewAuto.Domain.Model.Color
{
    public interface ICarColor
    {
        long Key { get; }
        string Name { get; }
        string Hex { get; }
    }
}