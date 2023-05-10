using EventPlanner.API.Abstractions;
using EventPlanner.Application.Dtos;
using EventPlanner.Application.Queries.Conference;
using EventPlanner.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceController : ApiController
    {
        public ConferenceController(ISender sender) : base(sender)
        {
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetConferenceById(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetConferenceByIdQuery(id);

            Result<ConferenceResponse> response = await Sender.Send(
                query,
                cancellationToken);

            return response.IsSuccess
                ? Ok(response.Value)
                : NotFound(response.Error);
        }
    }
}
