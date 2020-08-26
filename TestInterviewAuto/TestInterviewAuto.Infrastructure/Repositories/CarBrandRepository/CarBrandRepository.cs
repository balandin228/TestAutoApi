using TestInterviewAuto.Domain.Model.Brand;

namespace TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository
{
    public class CarBrandRepository : EFRepository<Brand>, ICarBrandRepository
    {
        public CarBrandRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}