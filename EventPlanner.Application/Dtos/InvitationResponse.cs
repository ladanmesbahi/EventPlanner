using EventPlanner.Domain.Enums;

namespace EventPlanner.Application.Dtos
{
    public sealed record InvitationResponse(Guid InvitationId, InvitationStatus Status);
}
