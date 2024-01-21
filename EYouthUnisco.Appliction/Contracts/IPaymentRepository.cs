using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface IPaymentRepository : IAsyncRepository<PaymentOrder>
    {
        Task<bool> CreatePaymentAsync(PaymentOrder paymentOrder);
        Task<bool> UpdatePaymentAsync(PaymentOrder paymentOrder);
    }
}
