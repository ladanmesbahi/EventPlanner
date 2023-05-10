namespace EventPlanner.Application.Dtos
{
    public sealed record AttendeeResponse(Guid MemberId, DateTime CreatedOnUtc);
}
