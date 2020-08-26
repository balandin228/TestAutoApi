using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure.Repositories.CarColorRepository
{
    public class CarColorRepository : EFRepository<Color>, ICarColorRepository
    {
        public CarColorRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}