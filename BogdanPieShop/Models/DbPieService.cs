using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdanPieShop.Models
{
    public class DbPieService : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbPieService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPise()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }

    }
}
