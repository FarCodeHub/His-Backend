﻿

using DataAccess.Entities.His.Entities;
using System.Threading.Tasks;

namespace DataAccess.Repositories.His
{
    public interface ICenterLocationRepository : IRepository<CenterLocation>
    {
        Task<CenterLocation> FindByCenterId(long Id);
    }
}
