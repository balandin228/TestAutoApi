using System;
using System.Collections.Generic;
using System.Text;
using TestInterviewAuto.Domain.Model.CarColor;

namespace TestInterviewAuto.Infrastructure.Repositories.CarColorRepository
{
    public class CarColorRepository : EFRepository<CarColor>, ICarColorRepository
    {
        public CarColorRepository(AutoDbContext context) : base(context)
        {

        }
    }
}
