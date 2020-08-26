using TestInterviewAuto.Domain.Model.Color;

namespace TestInterviewAuto.Infrastructure.Repositories.CarColorRepository
{
    public class ColorRepository : EFRepository<Color>, IColorRepository
    {
        public ColorRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}