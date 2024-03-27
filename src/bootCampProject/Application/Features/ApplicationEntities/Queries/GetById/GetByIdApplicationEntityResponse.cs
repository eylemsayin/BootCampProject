using NArchitecture.Core.Application.Responses;

namespace Application.Features.ApplicationEntities.Queries.GetById;

public class GetByIdApplicationEntityResponse : IResponse
{
    public int Id { get; set; }
    public Guid ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public short ApplicationStateId { get; set; }
}
