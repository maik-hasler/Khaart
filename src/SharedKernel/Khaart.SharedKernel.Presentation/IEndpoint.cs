using Microsoft.AspNetCore.Routing;

namespace Khaart.SharedKernel.Presentation;

public interface IEndpoint
{
    void Map(IEndpointRouteBuilder app);
}
