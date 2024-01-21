using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Appliction.Features.Role.Commands.CreateRole;
using EYouthUnisco.Appliction.Features.User.Commands;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Payment.Command
{
    public class InitializePaymentCommandHandler : IRequestHandler<InitializePaymentCommand, string>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public InitializePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(InitializePaymentCommand request, CancellationToken cancellationToken)
        {
            Domain.PaymentOrder order = _mapper.Map<Domain.PaymentOrder>(request);

            InitializePaymentCommandValidator validator = new InitializePaymentCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Order is not valid");
            }

            order = await _paymentRepository.AddAsync(order);

            return order.Trn;
        }
    }
}
