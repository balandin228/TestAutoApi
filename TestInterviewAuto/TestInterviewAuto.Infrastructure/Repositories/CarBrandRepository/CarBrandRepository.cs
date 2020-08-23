using TestInterviewAuto.Domain.Model.CarBrand;

namespace TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository
{
    public class CarBrandRepository : EFRepository<CarBrand>, ICarBrandRepository
    {
        public CarBrandRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}