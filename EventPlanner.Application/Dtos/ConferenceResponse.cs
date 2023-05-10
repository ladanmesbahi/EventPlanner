namespace EventPlanner.Application.Dtos
{
    public sealed record ConferenceResponse(
   Guid Id,
   string Name,
   string? Location,
   string Creator,
   IReadOnlyCollection<AttendeeResponse> Attendees,
   IReadOnlyCollection<InvitationResponse> Invitations);
}
