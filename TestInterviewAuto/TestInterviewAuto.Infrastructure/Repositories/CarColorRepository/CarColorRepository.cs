using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure.Repositories.CarColorRepository
{
    public class CarColorRepository : EFRepository<CarColor>, ICarColorRepository
    {
        public CarColorRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}