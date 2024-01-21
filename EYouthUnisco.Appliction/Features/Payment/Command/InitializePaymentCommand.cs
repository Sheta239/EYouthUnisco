using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Payment.Command
{
    public class InitializePaymentCommand : IRequest<string>
    {
        public string trn { get; set; } = null!;
        public int paymentmethodId { get; set; }
        public Guid userId { get; set; }
        public Guid CourseId { get; set; }

    }
}
