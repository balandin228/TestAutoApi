using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestInterviewAuto.Domain.Model.Car;

namespace TestInterviewAuto.Infrastructure.Repositories.CarRepository
{
    public class CarRepository : EFRepository<Car>, ICarRepository
    {
        public CarRepository(AutoDbContext context) : base(context)
        {
        }

        protected override IQueryable<Car> Items => base.Items
            .Include(c => c.CarColor)
            .ThenInclude(x => x.Color)
            .Include(c=>c.CarBrand)
            .ThenInclude(x=>x.Brand);
    }
}