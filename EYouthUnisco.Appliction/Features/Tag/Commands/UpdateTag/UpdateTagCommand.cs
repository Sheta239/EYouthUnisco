using MediatR;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.UpdateTag
{
    public class UpdateTagCommand : IRequest
    {
        public string TagName { get; set; } = null!;

    }
}
