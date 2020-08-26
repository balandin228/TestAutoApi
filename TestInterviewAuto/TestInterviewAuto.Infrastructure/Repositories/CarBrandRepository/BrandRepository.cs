using TestInterviewAuto.Domain.Model.Brand;

namespace TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository
{
    public class BrandRepository : EFRepository<Brand>, IBrandRepository
    {
        public BrandRepository(AutoDbContext context) : base(context)
        {
            
        }
    }
}