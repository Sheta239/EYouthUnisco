using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Persistence.Repositories
{
    public class PaymentRepostory : BaseRepository<PaymentOrder>
    {
        public PaymentRepostory(UniscoDbContext dbContext) : base(dbContext)
        {
        }
    }
}
